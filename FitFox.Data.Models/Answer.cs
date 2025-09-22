using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models
{
	public class Answer
	{
		public Answer()
		{
			Id = Guid.NewGuid();
			Questions = new HashSet<Question>();
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

		public virtual ICollection<Question> Questions { get; set; }
		public bool IsDeleted { get; set; }
	}
}