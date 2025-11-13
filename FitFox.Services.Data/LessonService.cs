using FitFox.Data.Models;
using FitFox.Data.Repository.Interfaces;
using FitFox.Services.Data.Interfaces;
using FitFox.Web.ViewModels.Answer;
using FitFox.Web.ViewModels.Lesson;
using FitFox.Web.ViewModels.Question;
using Microsoft.EntityFrameworkCore;

namespace FitFox.Services.Data
{
	public class LessonService : BaseService, ILessonService
	{
		private readonly IRepository<Lesson, Guid> _lessonRepository;
		private readonly IRepository<Question, Guid> _questionRepository;

		public LessonService(IRepository<Lesson, Guid> lessonRepository,
							IRepository<Question, Guid> questionRepository)
		{
			_lessonRepository = lessonRepository;
			_questionRepository = questionRepository;
		}

		public async Task<IEnumerable<LessonViewModel>> GetAllLessonsAsync(Guid mapId)
		{
			var result = await _lessonRepository.GetAllAttached()
				.Where(l => !l.IsDeleted && l.Map.Id == mapId)
				.OrderBy(l => l.OrderNumber)
				.Select(l => new LessonViewModel()
				{
					Id = l.Id,
					Title = l.Title,
					MapId = l.MapId,
					OrderNumber = l.OrderNumber,
					XP = l.XP,
				})
				.ToListAsync();

			return result;
		}

		public async Task<QuestionViewModel> GetQuestionByLessonIdAsync(Guid lessonId, int questionIndex)
		{
			var lesson = await _lessonRepository.GetAllAttached()
				.Include(l => l.Questions)
				.ThenInclude(q => q.AnswerOptions)
				.FirstOrDefaultAsync(l => l.Id == lessonId);


			if (lesson == null)
			{
				throw new Exception("Lesson not found!");
			}

			var orderedQuestions = lesson.Questions.OrderBy(q => q.OrderNumber).ToList();

			if (questionIndex < 0 || questionIndex >= orderedQuestions.Count)
			{
				return null;
			}

			var question = orderedQuestions[questionIndex];

			if (question == null)
			{
				throw new Exception("Question not found!");
			}

			var questionModel = new QuestionViewModel()
			{
				Id = question.Id,
				CorrectAnswerId = (Guid)question.CorrectAnswerId!,
				Text = question.Text,
				AnswersOptions = question.AnswerOptions.Select(a => new AnswerViewModel()
				{
					Id = a.Id,
					Text = a.Text,
				})
				.ToList()
			};

			return questionModel;
		}

		public async Task<(bool IsCorrect, Guid LessonId)> CheckAnswerAsync(Guid questionId, Guid selectedAnswerId, Guid lessonId)
		{
			var question = await _questionRepository.GetAllAttached()
				.FirstOrDefaultAsync(q => q.Id == questionId);

			if (question == null)
			{
				throw new Exception("Question not found!");
			}

			if (question.CorrectAnswerId == selectedAnswerId)
			{
				return (true, lessonId);
			}

			return (false, lessonId);
		}

		public async Task<QuestionResult> FillQuestionResultModel(Guid lessonId, Guid questionId, Guid selectedAnswerId)
		{
			var lesson = await _lessonRepository.GetAllAttached()
				.Include(l => l.Questions)
				.ThenInclude(q => q.AnswerOptions)
				.Include(l => l.Questions)
				.ThenInclude(q => q.CorrectAnswer)
				.FirstOrDefaultAsync(l => l.Id == lessonId);

			if (lesson == null)
			{
				throw new Exception("Lesson not found!");
			}

			var question = lesson.Questions.FirstOrDefault(q => q.Id == questionId);

			if (question == null)
			{
				throw new Exception("Question not found!");
			}

			QuestionResult questionResult = new QuestionResult()
			{
				QuestionId = questionId,
				QuestionTitle = question.Text,
				SelectedAnswer = question.AnswerOptions.FirstOrDefault(a => a.Id == selectedAnswerId)!.Text,
				CorrectAnswer = question.CorrectAnswer.Text,
			};

			return questionResult;
		}
	}
}
