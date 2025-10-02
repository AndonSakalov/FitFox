using FitFox.Data.Models;
using FitFox.Data.Repository.Interfaces;
using FitFox.Services.Data.Interfaces;
using FitFox.Web.ViewModels.Lesson;
using Microsoft.EntityFrameworkCore;

namespace FitFox.Services.Data
{
	public class LessonService : BaseService, ILessonService
	{
		private readonly IRepository<Lesson, Guid> _lessonRepository;

		public LessonService(IRepository<Lesson, Guid> lessonRepository)
		{
			_lessonRepository = lessonRepository;
		}
		public async Task<IEnumerable<LessonViewModel>> GetAllLessons()
		{
			var result = await _lessonRepository.GetAllAttached()
				.Where(l => !l.IsDeleted)
				.Select(l => new LessonViewModel()
				{
					Id = l.Id,
					Title = l.Title,
					MapId = l.MapId,
					OrderNumber = l.OrderNumber,
					XP = l.XP,
				})
				.ToListAsync();

			return null;
		}
	}
}
