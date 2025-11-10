using FitFox.Web.ViewModels.Lesson;
using FitFox.Web.ViewModels.Question;

namespace FitFox.Services.Data.Interfaces
{
	public interface ILessonService
	{
		Task<IEnumerable<LessonViewModel>> GetAllLessonsAsync(Guid mapId);

		Task<QuestionViewModel> GetQuestionByLessonIdAsync(Guid lessonId, int questionIndex = 0);

		Task<(bool IsCorrect, Guid LessonId)> CheckAnswerAsync(Guid questionId, Guid selectedAnswerId, Guid lessonId);

		Task<QuestionResult> FillQuestionResultModel(Guid lessonId, Guid questionId, Guid selectedAnswerId);
	}
}
