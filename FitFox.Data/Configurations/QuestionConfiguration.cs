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
				.WithOne(a => a.Question)
				.HasForeignKey(q => q.QuestionId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasData(new List<Question>()
				{
					new Question()
					{
						Id = Guid.Parse("65e73cd9-dec1-4e46-8342-69b204c6b226"),
						Text = "Which are the 3 macronutrients?",
						CorrectAnswerId = Guid.Parse("995bd8c0-98e5-441b-96f2-046c4e732022"),
						LessonId = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834")
					},
					new Question()
					{
						Id = Guid.Parse("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45"),
						Text = "Which macronutrient regulates hormone production?",
						CorrectAnswerId = Guid.Parse("ad15d6de-bc27-4f9c-925f-6efe5023521b"),
						LessonId = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834")
					},
					new Question()
					{
						Id = Guid.Parse("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56"),
						Text = "Which macronutrient is the main source of energy for the body?",
						CorrectAnswerId = Guid.Parse("971018fd-870c-4834-b53e-9db728272f58"),
						LessonId = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834")
					},
					new Question()
					{
						Id = Guid.Parse("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78"),
						Text = "Which nutrient is primarily used for muscle repair?",
						CorrectAnswerId = Guid.Parse("cd72868e-1d3c-40e2-99d2-9be1c6482f07"),
						LessonId = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834")
					},
					new Question()
					{
						Id = Guid.Parse("83fc33fc-0db2-4695-a950-c494eb58a73c"),
						Text = "How many calories does 1 gram of fat contain?",
						CorrectAnswerId = Guid.Parse("5b2e033a-3b69-42df-9b10-ac04fefbc4bd"),
						LessonId = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834")
					},
					new Question()
					{
						Id = Guid.Parse("e58fca52-c2da-44a4-b62f-9bd9bd7bb583"),
						Text = "How many calories does 1 gram of carbohydrates contain?",
						CorrectAnswerId = Guid.Parse("e00f1bae-9e02-4afb-871f-23a1a3a9884f"),
						LessonId = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834")
					},
					new Question()
					{
						Id = Guid.Parse("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce"),
						Text = "How many calories does 1 gram of protein contain?",
						CorrectAnswerId = Guid.Parse("fe9167a4-2f11-4875-899d-83c9d4b031b7"),
						LessonId = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834")
					}
				});
		}
	}
}
