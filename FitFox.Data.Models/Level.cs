using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models
{
	public class Level
	{
		public Level()
		{
			Id = Guid.NewGuid();
		}

		[Required]
		[Comment("The identifier of the level.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The number representing the level. Incrementing by 1.")]
		[Range(0, 100)]
		public int LevelNumber { get; set; }

		[Comment("The title granted for the level. Every 10 levels the user gets title of the level.")]
		public string? LevelTitle { get; set; }

		[Required]
		[Comment("The XP that is required to get to this level.")]
		public int RequiredXP { get; set; }
	}
}
