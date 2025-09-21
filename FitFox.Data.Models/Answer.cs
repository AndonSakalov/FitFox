using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models
{
	public class Answer
	{
		public Answer()
		{
			Id = Guid.NewGuid();
			IsDeleted = false;
		}

		[Required]
		[Comment("The identifier of the answer.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The answer content.")]
		[MinLength(3)]
		[MaxLength(200)]
		public string Text { get; set; } = null!;

		public bool IsDeleted { get; set; }
	}
}