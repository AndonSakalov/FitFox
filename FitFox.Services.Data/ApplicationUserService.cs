using FitFox.Data.Models;
using FitFox.Data.Models.MappingModels;
using FitFox.Data.Repository.Interfaces;
using FitFox.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitFox.Services.Data
{
	internal class ApplicationUserService : BaseService, IApplicationUserService
	{
		private readonly IRepository<ApplicationUser, Guid> _applicationUserRepository;
		private readonly IRepository<Map, Guid> _mapRepository;

		public ApplicationUserService(
			IRepository<ApplicationUser, Guid> applicationUserRepository,
			IRepository<Map, Guid> mapRepository)
		{
			_applicationUserRepository = applicationUserRepository;
			_mapRepository = mapRepository;
		}
		public async Task StartMapForUserAsync(Guid mapId, Guid userId)
		{
			var user = await _applicationUserRepository.GetAllAttached()
				.Include(u => u.UserMaps)
				.FirstOrDefaultAsync(u => u.Id == userId);
			var map = await _mapRepository.GetByIdAsync(mapId);

			if (map == null || user == null)
			{
				throw new Exception("Map or User not found!");
			}

			bool alreadyStarted = user.UserMaps.Any(m => m.MapId == map.Id);

			if (!alreadyStarted)
			{
				var userMap = new UserMap()
				{
					MapId = mapId,
					UserId = userId,
				};

				user.UserMaps.Add(userMap);
				await _applicationUserRepository.UpdateAsync(user);
			}
		}
	}
}
