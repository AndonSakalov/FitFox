using FitFox.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitFox.Controllers
{
	public class MapController : Controller
	{
		private readonly IMapService _mapService;
		public MapController(IMapService mapService)
		{
			_mapService = mapService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllMaps()
		{
			var outputModel = await _mapService.GetAllMapsAsync();
			return View(outputModel);
		}
	}
}
