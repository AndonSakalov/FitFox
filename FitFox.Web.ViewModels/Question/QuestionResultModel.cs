using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Question
{
	public class QuestionResult
	{
		[Required]
		public Guid QuestionId { get; set; }

		public bool IsCorrect { get; set; }

		[Required]
		public string QuestionTitle { get; set; } = null!;

		[Required]
		public string SelectedAnswer { get; set; } = null!;

		[Required]
		public string CorrectAnswer { get; set; } = null!;
	}
}
