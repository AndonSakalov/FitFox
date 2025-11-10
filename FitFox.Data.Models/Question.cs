using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

		[Key]
		[Required]
		[Comment("Identifier of the question.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The question content.")]
		[MinLength(5)]
		[MaxLength(200)]
		public string Text { get; set; } = null!;

		//[Required]
		[Comment("The identifier of the correct answer.")]
		public Guid? CorrectAnswerId { get; set; }

		[Comment("The correct answer, loaded lazily.")]
		[ForeignKey(nameof(CorrectAnswerId))]
		public virtual Answer CorrectAnswer { get; set; } = null!;
		public virtual ICollection<Answer> AnswerOptions { get; set; }

		[Required]
		[Comment("Identifier of the lesson that this question belongs to.")]
		public Guid LessonId { get; set; }

		[ForeignKey(nameof(LessonId))]
		public virtual Lesson Lesson { get; set; } = null!;

		[Required]
		public int OrderNumber { get; set; }

		public bool IsDeleted { get; set; }
	}
}
