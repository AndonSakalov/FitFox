using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models.MappingModels
{
	public class UserAchievement
	{
		[Required]
		public Guid UserId { get; set; }
		public virtual ApplicationUser User { get; set; } = null!;

		[Required]
		public Guid AchievementId { get; set; }
		public virtual Achievement Achievement { get; set; } = null!;

		[Required]
		public DateTime EarnedOn { get; set; }
	}
}
