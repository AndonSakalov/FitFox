using FitFox.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitFox.Controllers
{
	[Authorize]
	public class LessonController : Controller
	{
		private readonly ILessonService _lessonService;

		public LessonController(ILessonService lessonService)
		{
			_lessonService = lessonService;
		}


		[HttpGet]
		public Task<IActionResult> GetMapLessons(Guid mapId)
		{
			return null; //continue
		}
	}
}
