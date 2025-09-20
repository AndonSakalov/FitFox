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
		}

		[Comment("The current xp of the user.")]
		[Range(0, int.MaxValue)]
		public int CurrentXP { get; set; }

		[Comment("Identifier of the level.")]
		public Guid LevelId { get; set; }

		[Comment("The current level of the user.")]
		public virtual Level Level { get; set; }

		[Comment("Collection of the User's achievements.")]
		public virtual ICollection<Achievement> Achievements { get; set; }

		[Comment("Collection of the User's finished lessons.")]
		public virtual ICollection<Lesson> CompletedLessons { get; set; }
	}
}
