using FitFox.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations
{
	public class QuestionConfiguration : IEntityTypeConfiguration<Question>
	{
		public void Configure(EntityTypeBuilder<Question> builder)
		{
			builder.HasKey(q => q.Id);

			builder.HasMany(q => q.AnswerOptions)
				.WithMany(a => a.Questions)
				.UsingEntity(j => j.ToTable("QuestionAnswers"));

			builder.HasOne(q => q.CorrectAnswer)
				.WithOne()
				.HasForeignKey<Question>(q => q.CorrectAnswerId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
