using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models
{
	public class Lesson
	{
		public Lesson()
		{
			Id = Guid.NewGuid();
		}

		[Comment("The identifier of the lesson.")]
		public Guid Id { get; set; }

		[Comment("The tile of the lesson.")]
		[MinLength(3)]
		[MaxLength(100)]
		public string Title { get; set; }

		[Comment("The amount of XP this lesson grants the user on completion.")]
		[Range(1, 1000)]
		public int XP { get; set; }

		[Comment("The identifier of the map that this lesson belongs to.")]
		public Guid MapId { get; set; }

		[Comment("The Map that this lesson belongs to. Mapped lazily.")]
		public virtual Map Map { get; set; }

		public virtual ICollection<Question> Questions { get; set; }
	}
}
