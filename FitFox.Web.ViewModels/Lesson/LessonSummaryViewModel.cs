using FitFox.Web.ViewModels.Question;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Lesson
{
	public class LessonSummaryViewModel
	{
		[Required]
		public List<QuestionResult> QuestionResults { get; set; } = new List<QuestionResult>();

		[Required]
		public bool HasPassed { get; set; } = false;

		[Required]
		public bool HasLeveledUp { get; set; } = false;
	}
}
