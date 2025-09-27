using FitFox.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations
{
	public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
	{
		public void Configure(EntityTypeBuilder<Answer> builder)
		{
			builder.HasKey(a => a.Id);

			builder.HasOne(a => a.Question)
				.WithMany(q => q.AnswerOptions)
				.HasForeignKey(a => a.QuestionId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasData(new List<Answer>()
			{
				//Question: Which are the 3 macronutrients?
				new Answer()
				{
					Id = Guid.Parse("995bd8c0-98e5-441b-96f2-046c4e732022"),
					Text = "Protein, Fats, Carbohydrates",
					QuestionId = Guid.Parse("65e73cd9-dec1-4e46-8342-69b204c6b226")
				},
				new Answer()
				{
					Id = Guid.Parse("6f682b25-0953-45bc-b4aa-3f77c44f0abd"),
					Text = "Fiber, Antioxidants, Enzymes",
					QuestionId = Guid.Parse("65e73cd9-dec1-4e46-8342-69b204c6b226")
				},
				new Answer()
				{
					Id = Guid.Parse("754eb19b-0e7b-4f1f-aa8b-214b0c9e4ca1"),
					Text = "Vitamin C, Vitamin D, Vitamin E",
					QuestionId = Guid.Parse("65e73cd9-dec1-4e46-8342-69b204c6b226")
				},

				//Question: Which macronutrient regulates hormone production?
				new Answer()
				{
					Id = Guid.Parse("5635556a-dc6d-4a95-a804-a353787f29ac"),
					Text = "Protein",
					QuestionId = Guid.Parse("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45")
				},
				new Answer()
				{
					Id = Guid.Parse("ad15d6de-bc27-4f9c-925f-6efe5023521b"),
					Text = "Fats",
					QuestionId = Guid.Parse("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45")
				},
				new Answer()
				{
					Id = Guid.Parse("5f018738-98c2-45c8-91a8-4048ec7550ea"),
					Text = "Carbohydrates",
					QuestionId = Guid.Parse("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45")
				},

				//Question: Which macronutrient is the main source of energy for the body?
				new Answer()
				{
					Id = Guid.Parse("076d322b-61a0-4617-b7c7-adcfcd0e4a64"),
					Text = "Protein",
					QuestionId = Guid.Parse("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56")
				},
				new Answer()
				{
					Id = Guid.Parse("fc67a38b-6748-4df0-bdec-64ae01dce087"),
					Text = "Fats",
					QuestionId = Guid.Parse("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56")
				},
				new Answer()
				{
					Id = Guid.Parse("971018fd-870c-4834-b53e-9db728272f58"),
					Text = "Carbohydrates",
					QuestionId = Guid.Parse("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56")
				},

				//Question: Which nutrient is primarily used for muscle repair?
				new Answer()
				{
					Id = Guid.Parse("cd72868e-1d3c-40e2-99d2-9be1c6482f07"),
					Text = "Protein",
					QuestionId = Guid.Parse("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78")
				},
				new Answer()
				{
					Id = Guid.Parse("b052eb19-2983-4845-9e63-9cb44b67c5f1"),
					Text = "Fats",
					QuestionId = Guid.Parse("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78")
				},
				new Answer()
				{
					Id = Guid.Parse("b975ac50-9a54-4c2e-b36b-d57520da15b3"),
					Text = "Carbohydrates",
					QuestionId = Guid.Parse("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78")
				},

				//Question: How many calories does 1 gram of fat contain?
				new Answer()
				{
					Id = Guid.Parse("0b5e5a13-fa78-4329-9e1e-704b4e34c50a"),
					Text = "6",
					QuestionId = Guid.Parse("83fc33fc-0db2-4695-a950-c494eb58a73c")
				},
				new Answer()
				{
					Id = Guid.Parse("84aa5695-c7af-4620-bb4e-fa860502744e"),
					Text = "4",
					QuestionId = Guid.Parse("83fc33fc-0db2-4695-a950-c494eb58a73c")
				},
				new Answer()
				{
					Id = Guid.Parse("5b2e033a-3b69-42df-9b10-ac04fefbc4bd"),
					Text = "9",
					QuestionId = Guid.Parse("83fc33fc-0db2-4695-a950-c494eb58a73c")
				},

				//Question: How many calories does 1 gram of carbohydrates contain?
				new Answer()
				{
					Id = Guid.Parse("bc272712-432e-4429-bbc0-c489ff3f0380"),
					Text = "5",
					QuestionId = Guid.Parse("e58fca52-c2da-44a4-b62f-9bd9bd7bb583")
				},
				new Answer()
				{
					Id = Guid.Parse("e00f1bae-9e02-4afb-871f-23a1a3a9884f"),
					Text = "4",
					QuestionId = Guid.Parse("e58fca52-c2da-44a4-b62f-9bd9bd7bb583")
				},
				new Answer()
				{
					Id = Guid.Parse("8a153745-ee3c-4fcb-b4cb-e73590bd90e3"),
					Text = "9",
					QuestionId = Guid.Parse("e58fca52-c2da-44a4-b62f-9bd9bd7bb583")
				},

				//Question: How many calories does 1 gram of protein contain?
				new Answer()
				{
					Id = Guid.Parse("995c9a90-88fe-4fd2-8762-e3d46c2ea813"),
					Text = "2",
					QuestionId = Guid.Parse("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce")
				},
				new Answer()
				{
					Id = Guid.Parse("fe9167a4-2f11-4875-899d-83c9d4b031b7"),
					Text = "4",
					QuestionId = Guid.Parse("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce")
				},
				new Answer()
				{
					Id = Guid.Parse("a2845dd5-e2c0-4c39-87dd-255e08156b89"),
					Text = "9",
					QuestionId = Guid.Parse("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce")
				},
			});
		}
	}
}
