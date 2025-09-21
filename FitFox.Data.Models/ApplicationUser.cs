using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models
{
	public class ApplicationUser : IdentityUser<Guid>
	{
		public ApplicationUser()
		{
			this.Id = Guid.NewGuid();
			this.CurrentXP = 0;
			Achievements = new HashSet<Achievement>();
			CompletedLessons = new HashSet<Lesson>();
			MapsCompleted = new HashSet<Map>();
		}

		[Comment("The current XP of the user. Overall XP, not of the current level.")]
		[Range(0, int.MaxValue)]
		public int CurrentXP { get; set; }

		[Required]
		[Comment("Identifier of the level.")]
		public Guid LevelId { get; set; }

		[Comment("The current level of the user. Loaded lazily.")]
		public virtual Level Level { get; set; } = null!;

		[Comment("Collection of the User's achievements.")]
		public virtual ICollection<Achievement> Achievements { get; set; }

		[Comment("Collection of the User's finished lessons.")]
		public virtual ICollection<Lesson> CompletedLessons { get; set; }

		[Comment("Collection of the User's finished maps.")]
		public virtual ICollection<Map> MapsCompleted { get; set; }
	}
}
