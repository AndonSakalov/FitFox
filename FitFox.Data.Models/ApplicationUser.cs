using FitFox.Data.Models.MappingModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitFox.Data.Models
{
	public class ApplicationUser : IdentityUser<Guid>
	{
		public ApplicationUser()
		{
			this.Id = Guid.NewGuid();
			this.CurrentXP = 0;
			UserAchievements = new HashSet<UserAchievement>();
			UserLessons = new HashSet<UserLesson>();
			UserMaps = new HashSet<UserMap>();

			IsDeleted = false;
		}

		[Comment("The current XP of the user. Overall XP, not of the current level.")]
		[Range(0, int.MaxValue)]
		public int CurrentXP { get; set; }

		[Required]
		[Comment("Identifier of the level.")]
		public Guid LevelId { get; set; }

		[Comment("The current level of the user. Loaded lazily.")]
		[ForeignKey(nameof(LevelId))]
		public virtual Level Level { get; set; } = null!;

		[Comment("Collection of the User's achievements.")]
		public virtual ICollection<UserAchievement> UserAchievements { get; set; }

		[Comment("Collection of the User's finished lessons.")]
		public virtual ICollection<UserLesson> UserLessons { get; set; }

		[Comment("Collection of the User's finished maps.")]
		public virtual ICollection<UserMap> UserMaps { get; set; }

		public bool IsDeleted { get; set; }
	}
}
