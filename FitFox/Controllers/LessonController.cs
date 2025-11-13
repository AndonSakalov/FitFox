using FitFox.Data.Models;
using FitFox.Services.Data.Interfaces;
using FitFox.Web.ViewModels.Lesson;
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
		public async Task<IActionResult> MarkLessonPassed(Guid lessonId)
		{
			var user = await _userManager.GetUserAsync(User);

			if (user == null)
			{
				return Unauthorized();
			}
			var key = $"LessonResults_{lessonId}";
			var json = HttpContext.Session.GetString(key);

			var results = System.Text.Json.JsonSerializer.Deserialize<List<QuestionResult>>(json)!;

			var model = new LessonSummaryViewModel()
			{
				QuestionResults = results,
			};

			if (results.Where(qr => qr.IsCorrect).Count() == results.Count()) //Success
			{
				model.HasPassed = true; //HasPassed = false; by default
			}

			if (model.HasPassed)
			{
				var result = await _userService.GrantUserXp(user.Id, lessonId);

				if (!result)
				{
					throw new Exception("Cant grant XP!");
				}

				await _userService.MarkLessonAsPassed(lessonId, user.Id);
			}

			return RedirectToAction("LessonSummary", "Lesson", new { lessonId });
		}

		[HttpGet]
		public async Task<IActionResult> SolveLesson(Guid lessonId, int questionIndex = 0)
		{
			var question = await _lessonService.GetQuestionByLessonIdAsync(lessonId, questionIndex);

			if (question == null)
			{
				return RedirectToAction("MarkLessonPassed", "Lesson", new { lessonId });
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

		[HttpGet]
		public async Task<IActionResult> LessonSummary(Guid lessonId)
		{
			var key = $"LessonResults_{lessonId}";
			var json = HttpContext.Session.GetString(key);

			if (json == null)
			{
				return View(new List<QuestionResult>());
			}

			var results = System.Text.Json.JsonSerializer.Deserialize<List<QuestionResult>>(json)!;

			var model = new LessonSummaryViewModel()
			{
				QuestionResults = results,
			};

			if (results.Where(qr => qr.IsCorrect).Count() == results.Count()) //Success
			{
				model.HasPassed = true; //HasPassed = false; by default
			}

			return View(model); //AJAX>POST method to grant xp and update the 
		}

	}
}
