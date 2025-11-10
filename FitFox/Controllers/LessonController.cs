using FitFox.Data.Models;
using FitFox.Services.Data.Interfaces;
using FitFox.Web.ViewModels.Question;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitFox.Controllers
{
	[Authorize]
	public class LessonController : Controller
	{
		private readonly ILessonService _lessonService;
		private readonly IApplicationUserService _userService;
		private readonly UserManager<ApplicationUser> _userManager;

		public LessonController(ILessonService lessonService,
								IApplicationUserService userService,
								UserManager<ApplicationUser> userManager)
		{
			_lessonService = lessonService;
			_userService = userService;
			_userManager = userManager;
		}


		[HttpGet]
		public async Task<IActionResult> GetMapLessons(Guid mapId)
		{
			var outputModel = await _lessonService.GetAllLessonsAsync(mapId);

			return View(outputModel);
		}

		[HttpPost]
		public async Task<IActionResult> StartLesson(Guid lessonId)
		{
			var user = await _userManager.GetUserAsync(User);

			if (user == null)
			{
				return Unauthorized();
			}

			await _userService.StartLessonForUserAsync(lessonId, user.Id);

			return RedirectToAction("SolveLesson", "Lesson", new { lessonId }); //Continue here, reload page after every question + info on wrong ones
		}

		[HttpGet]
		public async Task<IActionResult> SolveLesson(Guid lessonId, int questionIndex = 0)
		{
			var question = await _lessonService.GetQuestionByLessonIdAsync(lessonId, questionIndex);

			if (question == null)
			{
				return RedirectToAction("LessonSummary", "Lesson", new { lessonId });
			}

			ViewBag.LessonId = lessonId;
			ViewBag.QuestionIndex = questionIndex;

			return View(question);
		}

		[HttpPost]
		public async Task<IActionResult> CheckAnswer(Guid lessonId, Guid questionId, Guid selectedAnswerId, int questionIndex)
		{
			var result = await _lessonService.CheckAnswerAsync(questionId, selectedAnswerId, lessonId);

			var key = $"LessonResults_{lessonId}";

			var json = HttpContext.Session.GetString(key);
			var results = json != null
				? System.Text.Json.JsonSerializer.Deserialize<List<QuestionResult>>(json)! //possible problem
				: new List<QuestionResult>();

			var existing = results.FirstOrDefault(r => r.QuestionId == questionId);
			if (existing != null)
			{
				existing.IsCorrect = result.IsCorrect;
			}
			else
			{
				var modelPartial = await _lessonService.FillQuestionResultModel(lessonId, questionId, selectedAnswerId);
				modelPartial.IsCorrect = result.IsCorrect;

				results.Add(modelPartial);
			}

			HttpContext.Session.SetString(key, System.Text.Json.JsonSerializer.Serialize(results));

			var nextQuestion = await _lessonService.GetQuestionByLessonIdAsync(lessonId, questionIndex + 1);
			bool hasNext = nextQuestion != null;

			return Json(new
			{
				isCorrect = result.IsCorrect,
				nextIndex = questionIndex + 1,
				goToSummary = !hasNext
			});
		}

		public IActionResult LessonSummary(Guid lessonId)
		{
			var key = $"LessonResults_{lessonId}";
			var json = HttpContext.Session.GetString(key);

			if (json == null)
			{
				return View(new List<QuestionResult>());
			}

			var results = System.Text.Json.JsonSerializer.Deserialize<List<QuestionResult>>(json);

			return View(results);
		}

	}
}
