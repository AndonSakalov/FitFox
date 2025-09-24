using FitFox.Data.Models;
using FitFox.Data.Repository.Interfaces;
using FitFox.Services.Data.Interfaces;
using FitFox.Web.ViewModels.Map;
using Microsoft.EntityFrameworkCore;

namespace FitFox.Services.Data
{
	public class MapService : BaseService, IMapService
	{
		private readonly IRepository<Map, Guid> _mapRepository;

		public MapService(IRepository<Map, Guid> mapRepository)
		{
			_mapRepository = mapRepository;
		}
		public async Task<IEnumerable<MapViewModel>> GetAllMapsAsync()
		{

			var result = await _mapRepository.GetAllAttached()
			.Where(m => !m.IsDeleted)
			.Select(m => new MapViewModel
			{
				Id = m.Id,
				Title = m.Title,
				MapCategory = m.MapCategory,
				Description = m.Description
			})
			.ToListAsync();

			return result;
		}
	}
}
