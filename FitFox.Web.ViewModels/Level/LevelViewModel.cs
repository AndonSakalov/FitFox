using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Level
{
	public class LevelViewModel
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		public int LevelNumber { get; set; }

		public string? LevelTitle { get; set; }
	}
}
