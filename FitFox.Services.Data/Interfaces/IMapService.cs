using FitFox.Web.ViewModels.Map;

namespace FitFox.Services.Data.Interfaces
{
	public interface IMapService
	{
		Task<IEnumerable<MapViewModel>> GetAllMapsAsync();
	}
}
