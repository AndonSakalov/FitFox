using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Answer
{
	public class AnswerViewModel
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		public string Text { get; set; } = null!;
	}
}
