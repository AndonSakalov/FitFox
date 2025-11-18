using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Achievement
{
	public class AchievementGrantedViewModel
	{
		[Required]
		public Guid Id { get; set; }
		[Required]
		public string Title { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
	}
}
