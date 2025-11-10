using FitFox.Web.ViewModels.Answer;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Question
{
	public class QuestionViewModel
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		public string Text { get; set; } = null!;

		public Guid CorrectAnswerId { get; set; }

		public List<AnswerViewModel> AnswersOptions { get; set; } = new List<AnswerViewModel>();
	}
}
