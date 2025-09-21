using FitFox.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models
{
	public class Achievement
	{
		public Achievement()
		{
			this.Id = Guid.NewGuid();
			AchievementUsers = new HashSet<UserAchievement>();
			IsDeleted = false;
		}

		[Required]
		[Comment("The Identifier of the achievement.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The title of the achievement.")]
		[MinLength(2)]
		[MaxLength(50)]
		public string Title { get; set; } = null!;

		[Required]
		[Comment("What has been achieved in order to get this achievement.")]
		[MinLength(10)]
		[MaxLength(250)]
		public string Description { get; set; } = null!;

		[Required]
		[Comment("The condition for this achievement - LessonsLearned, MapsCovered, DailyQuestsCompleted, etc.")]
		public ConditionType ConditionType { get; set; }

		[Required]
		[Comment("The value needed to get this achievement.")]
		[Range(0, int.MaxValue)]
		public int ConditionValue { get; set; }

		[Required]
		[Comment("The Url to the achievement's icon.")]
		[MinLength(1)]
		[MaxLength(2048)]
		public string IconUrl { get; set; } = null!;
		public virtual ICollection<UserAchievement> AchievementUsers { get; set; }

		public bool IsDeleted { get; set; }
	}
}
