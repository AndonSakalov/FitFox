using FitFox.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Map
{
	public class MapViewModel
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		public MapCategory MapCategory { get; set; }

		[Required]
		public string Title { get; set; } = null!;

		[Required]
		public string Description { get; set; } = null!;

	}
}
