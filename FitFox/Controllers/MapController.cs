using FitFox.Data.Models;
using FitFox.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitFox.Controllers
{
	[Authorize]
	public class MapController : Controller
	{
		private readonly IMapService _mapService;
		private readonly IApplicationUserService _userService;
		private readonly UserManager<ApplicationUser> _userManager;
		public MapController(IMapService mapService, UserManager<ApplicationUser> userManager, IApplicationUserService userService)
		{
			_mapService = mapService;
			_userService = userService;
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllMaps()
		{
			var outputModel = await _mapService.GetAllMapsAsync();
			return View(outputModel);
		}

		[HttpPost]
		public async Task<IActionResult> StartMap(Guid mapId)
		{
			var user = await _userManager.GetUserAsync(User);

			if (user == null)
			{
				return Unauthorized();
			}

			await _userService.StartMapForUserAsync(mapId, user.Id);

			return RedirectToAction("GetMapLessons", "Lesson", new { mapId });
		}
	}
}
