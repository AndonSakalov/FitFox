using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Achievement
{
	public class AchievementViewModel
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		public string Title { get; set; } = null!;

		[Required]
		public string Description { get; set; } = null!;

		[Required]
		[MinLength(1)]
		[MaxLength(2048)]
		public string IconURL { get; set; } = null!;
	}
}
