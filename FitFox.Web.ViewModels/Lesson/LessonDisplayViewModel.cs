using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Lesson
{
	public class LessonDisplayViewModel
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		public string Title { get; set; } = null!;

		[Required]
		public Guid MapId { get; set; }
	}
}
