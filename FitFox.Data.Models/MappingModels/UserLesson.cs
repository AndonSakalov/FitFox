using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models.MappingModels
{
	public class UserLesson
	{
		[Required]
		public Guid UserId { get; set; }
		public virtual ApplicationUser User { get; set; } = null!;

		[Required]
		public Guid LessonId { get; set; }
		public virtual Lesson Lesson { get; set; } = null!;
	}
}
