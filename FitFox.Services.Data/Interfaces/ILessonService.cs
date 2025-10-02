using FitFox.Web.ViewModels.Lesson;

namespace FitFox.Services.Data.Interfaces
{
	public interface ILessonService
	{
		Task<IEnumerable<LessonViewModel>> GetAllLessons();
	}
}
