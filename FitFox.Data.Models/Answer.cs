using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitFox.Data.Models
{
	public class Answer
	{
		public Answer()
		{
			Id = Guid.NewGuid();
			IsDeleted = false;
		}

		[Key]
		[Required]
		[Comment("The identifier of the answer.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The answer content.")]
		[MinLength(3)]
		[MaxLength(200)]
		public string Text { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(Question))]
		public Guid QuestionId { get; set; }

		public virtual Question Question { get; set; }
		public bool IsDeleted { get; set; }
	}
}