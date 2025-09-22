using FitFox.Data.Models.MappingModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitFox.Data.Models
{
	public class Lesson
	{
		public Lesson()
		{
			Id = Guid.NewGuid();
			Questions = new HashSet<Question>();
			LessonUsers = new HashSet<UserLesson>();
			IsDeleted = false;
		}

		[Key]
		[Required]
		[Comment("The identifier of the lesson.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The tile of the lesson.")]
		[MinLength(3)]
		[MaxLength(100)]
		public string Title { get; set; } = null!;

		[Required]
		[Comment("The amount of XP this lesson grants the user on completion.")]
		[Range(1, 1000)]
		public int XP { get; set; }

		[Required]
		[Comment("The identifier of the map that this lesson belongs to.")]
		public Guid MapId { get; set; }

		[Comment("The Map that this lesson belongs to. Mapped lazily.")]
		[ForeignKey(nameof(MapId))]
		public virtual Map Map { get; set; } = null!;

		[Comment("Collection of the questions that the lesson consists of.")]
		public virtual ICollection<Question> Questions { get; set; }

		public virtual ICollection<UserLesson> LessonUsers { get; set; }

		public bool IsDeleted { get; set; }
	}
}
