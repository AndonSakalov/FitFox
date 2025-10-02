namespace FitFox.Web.ViewModels.Lesson
{
	public class LessonViewModel
	{
		public Guid Id { get; set; }

		public string Title { get; set; } = null!;

		public Guid MapId { get; set; }

		public int OrderNumber { get; set; }

		public int XP { get; set; }
	}
}
