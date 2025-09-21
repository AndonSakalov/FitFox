using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models
{
	public class Question
	{
		public Question()
		{
			Id = Guid.NewGuid();
			AnswerOptions = new HashSet<Answer>();
			IsDeleted = false;
		}

		[Required]
		[Comment("Identifier of the question.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The question content.")]
		[MinLength(5)]
		[MaxLength(200)]
		public string Text { get; set; } = null!;

		[Required]
		[Comment("The identifier of the correct answer.")]
		public Guid CorrectAnswerId { get; set; }

		[Comment("The correct answer, loaded lazily.")]
		public virtual Answer CorrectAnswer { get; set; } = null!;

		public ICollection<Answer> AnswerOptions { get; set; }

		public bool IsDeleted { get; set; }
	}
}
