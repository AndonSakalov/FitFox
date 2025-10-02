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

				//Question: What is the typical protein intake per kg of body weight for a person trying to build muscle?
				new Answer()
				{
					Id = Guid.Parse("3c3fd6c5-5c2d-4ef4-b2a3-fdf7f4d7dc94"),
					Text = "1.7–2.5 grams",
					QuestionId = Guid.Parse("725ac1b4-5362-484a-964a-4a1bc95a2aab")
				},
				new Answer()
				{
					Id = Guid.Parse("f52e1b3e-4f48-4d48-9880-3ecfcf4cc91f"),
					Text = "0.5 grams",
					QuestionId = Guid.Parse("725ac1b4-5362-484a-964a-4a1bc95a2aab")
				},
				new Answer()
				{
					Id = Guid.Parse("04ff28e3-1c76-43fb-9f2e-50dc89d4574d"),
					Text = "5 grams",
					QuestionId = Guid.Parse("725ac1b4-5362-484a-964a-4a1bc95a2aab")
				},

				//Question: For a cutting diet, which macronutrient is often reduced first?
				new Answer()
				{
					Id = Guid.Parse("0f9d15b7-8b2f-4df7-8613-93d80d3d3c34"),
					Text = "Carbohydrates",
					QuestionId = Guid.Parse("ab0fda0c-dca4-4b12-a690-8e1b311ee5de")
				},
				new Answer()
				{
					Id = Guid.Parse("c145af32-bb34-4c58-8f6a-63b59ad2e497"),
					Text = "Proteins",
					QuestionId = Guid.Parse("ab0fda0c-dca4-4b12-a690-8e1b311ee5de")
				},
				new Answer()
				{
					Id = Guid.Parse("8f960e0f-3f31-4f12-abe7-8e055fba26b0"),
					Text = "Fats",
					QuestionId = Guid.Parse("ab0fda0c-dca4-4b12-a690-8e1b311ee5de")
				},

				//Question: Which macronutrient is usually prioritized for muscle gain?
				new Answer()
				{
					Id = Guid.Parse("6c44c89a-c257-4cd5-8653-c3f523b42f15"),
					Text = "Proteins",
					QuestionId = Guid.Parse("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4")
				},
				new Answer()
				{
					Id = Guid.Parse("3a5ef8a4-68ae-464a-8e93-7c4d8b1f1a5a"),
					Text = "Carbohydrates",
					QuestionId = Guid.Parse("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4")
				},
				new Answer()
				{
					Id = Guid.Parse("ac0270a6-9dc2-4c4c-9e40-16ac51137b34"),
					Text = "Fats",
					QuestionId = Guid.Parse("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4")
				},

				//Question: For someone on a low-carb diet, which macronutrient is usually increased to compensate for reduced carbs?
				new Answer()
				{
					Id = Guid.Parse("f3c7b58d-8fbb-4d6e-b2f5-3e6f2d9a7b21"),
					Text = "Fats",
					QuestionId = Guid.Parse("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee")
				},
				new Answer()
				{
					Id = Guid.Parse("d1f64c0a-7d32-466b-94ae-2b0a1f7d1f3f"),
					Text = "Proteins",
					QuestionId = Guid.Parse("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee")
				},
				new Answer()
				{
					Id = Guid.Parse("aa5d6f8b-2d44-4f0e-bd35-5e1c9d4b2f9e"),
					Text = "Carbohydrates",
					QuestionId = Guid.Parse("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee")
				},

				//Question: What is the main function of water in the body?
				new Answer()
				{
					Id = Guid.Parse("a8e4f0c5-5a2c-4e2e-98d1-0f7bfa36c1b7"),
					Text = "Transport nutrients and waste, as well as regulate body temperature",
					QuestionId = Guid.Parse("c29ae0bc-eb61-45c1-be09-2e24ca66862b")
				},
				new Answer()
				{
					Id = Guid.Parse("f2c3a97e-1b34-4a36-8f48-2f3c1d0d5a5b"),
					Text = "Store energy",
					QuestionId = Guid.Parse("c29ae0bc-eb61-45c1-be09-2e24ca66862b")
				},
				new Answer()
				{
					Id = Guid.Parse("b1d3e972-3f27-49f3-9e5b-5f2a8c4a2b89"),
					Text = "Produce hormones",
					QuestionId = Guid.Parse("c29ae0bc-eb61-45c1-be09-2e24ca66862b")
				},

				//Question: Which electrolyte is most important for muscle contraction and nerve function?
				new Answer()
				{
					Id = Guid.Parse("d0c6a5e2-3c2b-4f85-8ed2-1a9b6c7d4f2a"),
					Text = "Sodium",
					QuestionId = Guid.Parse("d76f8572-c76d-4ea6-96e2-88f94b2ef5db")
				},
				new Answer()
				{
					Id = Guid.Parse("e9a3d7b1-7c18-4f5e-9b3d-2c1f4a9e6d8b"),
					Text = "Potassium",
					QuestionId = Guid.Parse("d76f8572-c76d-4ea6-96e2-88f94b2ef5db")
				},
				new Answer()
				{
					Id = Guid.Parse("fa1c3b47-5e6a-4c8d-9e2b-0d9c2a4e7b1f"),
					Text = "Magnesium",
					QuestionId = Guid.Parse("d76f8572-c76d-4ea6-96e2-88f94b2ef5db")
				},

				//Question: Which electrolyte helps regulate heart rhythm and fluid balance?
				new Answer()
				{
					Id = Guid.Parse("b8f7d3c4-1a5b-4e8c-9d2a-0f4e3c7b2d1a"),
					Text = "Potassium",
					QuestionId = Guid.Parse("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90")
				},
				new Answer()
				{
					Id = Guid.Parse("c7e2f8b1-4d5a-4c9e-8b1c-3f2e6a4d1b2f"),
					Text = "Sodium",
					QuestionId = Guid.Parse("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90")
				},
				new Answer()
				{
					Id = Guid.Parse("d3f1b2a5-5e6c-4d9f-9c1a-2e3f4a5b6c7d"),
					Text = "Chloride",
					QuestionId = Guid.Parse("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90")
				},

				//Question: A common sign of dehydration is:
				new Answer()
				{
					Id = Guid.Parse("c3d2e1f0-4b5a-4c8d-9e2f-1a3b4c5d6e7f"),
					Text = "Excessive energy",
					QuestionId = Guid.Parse("4c550c86-a27f-480d-8a34-26a5d94d7bb3")
				},
				new Answer()
				{
					Id = Guid.Parse("f1b2d3a4-5e6c-4f8d-9a1b-2c3d4e5f6a7b"),
					Text = "Dark colored urine",
					QuestionId = Guid.Parse("4c550c86-a27f-480d-8a34-26a5d94d7bb3")
				},
				new Answer()
				{
					Id = Guid.Parse("d4e3f2a1-5b6c-4d8f-9a2b-3c4d5e6f7a8b"),
					Text = "High blood sugar",
					QuestionId = Guid.Parse("4c550c86-a27f-480d-8a34-26a5d94d7bb3")
				},

				//Question: How many liters of water are generally recommended per day for an average adult?
				new Answer()
				{
					Id = Guid.Parse("c7b6a5d4-8e9f-4f0a-9b2c-6d7e8f9a0b1d"),
					Text = "5 liters",
					QuestionId = Guid.Parse("3b1a72e5-e73e-4e8d-833e-b92a61eb2664")
				},
				new Answer()
				{
					Id = Guid.Parse("d8c7b6a5-9f0a-4b1c-8d3e-7f8a9b0c1d2e"),
					Text = "1 liter",
					QuestionId = Guid.Parse("3b1a72e5-e73e-4e8d-833e-b92a61eb2664")
				},
				new Answer()
				{
					Id = Guid.Parse("f6a5b4c3-7d8e-4f9a-8b1c-5d6e7f8a9b0c"),
					Text = "2–3 liters",
					QuestionId = Guid.Parse("3b1a72e5-e73e-4e8d-833e-b92a61eb2664")
				},

				//Question: Which electrolyte is often lost in large amounts through sweat?
				new Answer()
				{
					Id = Guid.Parse("c1f0e9d8-2b3c-4d5e-8f6a-0c1d2e3f4a5b"),
					Text = "Potassium",
					QuestionId = Guid.Parse("2cd2b95d-63c0-4c7f-9485-3df385a91476")
				},
				new Answer()
				{
					Id = Guid.Parse("f0e9d8c7-1b2c-4d3e-9f5a-9b0c1d2e3f4a"),
					Text = "Sodium",
					QuestionId = Guid.Parse("2cd2b95d-63c0-4c7f-9485-3df385a91476")
				},
				new Answer()
				{
					Id = Guid.Parse("d2c1f0e9-3b4c-4d6e-9f7b-1d2e3f4a5b6c"),
					Text = "Magnesium",
					QuestionId = Guid.Parse("2cd2b95d-63c0-4c7f-9485-3df385a91476")
				},

				//Question: "Magnesium helps with all of the following EXCEPT:"
				new Answer()
				{
					Id = Guid.Parse("f4e3d2c1-5b6c-4d8e-9f9d-3f4a5b6c7d8e"),
					Text = "Muscle relaxation",
					QuestionId = Guid.Parse("3bbce0fb-8e12-4a03-837d-9ac269f282ff")
				},
				new Answer()
				{
					Id = Guid.Parse("c5f4e3d2-6b7c-4d9f-8f0e-4a5b6c7d8e9f"),
					Text = "Improved sleep",
					QuestionId = Guid.Parse("3bbce0fb-8e12-4a03-837d-9ac269f282ff")
				},
				new Answer()
				{
					Id = Guid.Parse("d6c5f4e3-7b8c-4daf-9f1a-5b6c7d8e9f0a"),
					Text = "Muscle and nerve function",
					QuestionId = Guid.Parse("3bbce0fb-8e12-4a03-837d-9ac269f282ff")
				},

				//Question: Which protein source is considered “complete”, containing all essential amino acids?
				new Answer()
				{
					Id = Guid.Parse("c3b1f8a4-2d7e-4b9c-9a1f-0b6d3e5f7a1b"),
					Text = "Eggs",
					QuestionId = Guid.Parse("e74d6670-97b6-42c9-8464-881dbb6bfa9d")
				},
				new Answer()
				{
					Id = Guid.Parse("d1e5c2b3-3f8a-4c6d-8b9c-1d2e3f4a5b6c"),
					Text = "Rice",
					QuestionId = Guid.Parse("e74d6670-97b6-42c9-8464-881dbb6bfa9d")
				},
				new Answer()
				{
					Id = Guid.Parse("f2a3b4c5-4d9e-4f8a-9b0c-2f3d4e5a6b7c"),
					Text = "Lentils",
					QuestionId = Guid.Parse("e74d6670-97b6-42c9-8464-881dbb6bfa9d")
				},

				//Question: When is protein consumption most effective for muscle recovery?
				new Answer()
				{
					Id = Guid.Parse("c8d9e0f1-2b3c-4d5e-8f1a-4b6c7d8e9f0a"),
					Text = "Before sleep",
					QuestionId = Guid.Parse("b850b9da-babb-465e-96b4-99639f04711e")
				},
				new Answer()
				{
					Id = Guid.Parse("b7c8d9e0-1a2b-4c3d-9f4e-3a5b6c7d8e9f"),
					Text = "Immediately post-workout",
					QuestionId = Guid.Parse("b850b9da-babb-465e-96b4-99639f04711e")
				},
				new Answer()
				{
					Id = Guid.Parse("d9e0f1a2-3c4d-4e5f-9b2c-5c7d8e9f0a1b"),
					Text = "Anytime during the day",
					QuestionId = Guid.Parse("b850b9da-babb-465e-96b4-99639f04711e")
				},

				//Question: Which protein source is faster digesting and ideal post-workout?
				new Answer()
				{
					Id = Guid.Parse("e0f1a2b3-4d5e-4f6a-8c3d-6d7e8f9a0b1c"),
					Text = "Whey protein",
					QuestionId = Guid.Parse("34c91eb1-1e3b-4f7b-bf02-8b9f34653023")
				},
				new Answer()
				{
					Id = Guid.Parse("f1a2b3c4-5e6f-4d7a-9b4c-7e8f9a0b1c2d"),
					Text = "Casein protein",
					QuestionId = Guid.Parse("34c91eb1-1e3b-4f7b-bf02-8b9f34653023")
				},
				new Answer()
				{
					Id = Guid.Parse("a2b3c4d5-6f7e-4d8a-8c5d-8f9a0b1c2d3e"),
					Text = "Soy protein",
					QuestionId = Guid.Parse("34c91eb1-1e3b-4f7b-bf02-8b9f34653023")
				},

				//Question: Casein protein is best consumed:
				new Answer()
				{
					Id = Guid.Parse("c4d5e6f7-8a9b-4d0c-8e7f-0b1c2d3e4f5a"),
					Text = "Immediately post-workout",
					QuestionId = Guid.Parse("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794")
				},
				new Answer()
				{
					Id = Guid.Parse("d5e6f7a8-9b0c-4d1d-9f8a-1c2d3e4f5a6b"),
					Text = "Before breakfast",
					QuestionId = Guid.Parse("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794")
				},
				new Answer()
				{
					Id = Guid.Parse("b3c4d5e6-7f8a-4d9b-9d6e-9a0b1c2d3e4f"),
					Text = "Before sleep",
					QuestionId = Guid.Parse("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794")
				},

				//Question: Combining different plant proteins can help:
				new Answer()
				{
					Id = Guid.Parse("f7a8b9c0-1d2e-4d3f-9b0c-3e4f5a6b7c8d"),
					Text = "Reduce calorie intake",
					QuestionId = Guid.Parse("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5")
				},
				new Answer()
				{
					Id = Guid.Parse("a8b9c0d1-2e3f-4d4a-8c1d-4f5a6b7c8d9e"),
					Text = "Increase fat intake",
					QuestionId = Guid.Parse("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5")
				},
				new Answer()
				{
					Id = Guid.Parse("e6f7a8b9-0c1d-4d2e-8a9b-2d3e4f5a6b7c"),
					Text = "Provide all essential amino acids",
					QuestionId = Guid.Parse("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5")
				},

				//Question: Which of the following are considered micronutrients?
				new Answer()
				{
					Id = Guid.Parse("e8b0b203-90ba-4285-ad9e-493bd3592135"),
					Text = "Vitamins and Minerals",
					QuestionId = Guid.Parse("0ef6cf36-8764-4924-9b01-5fcc247c96aa")
				},
				new Answer()
				{
					Id = Guid.Parse("953254b5-a648-4737-b87d-4dd53394e84e"),
					Text = "Protein and Carbohydrates",
					QuestionId = Guid.Parse("0ef6cf36-8764-4924-9b01-5fcc247c96aa")
				},
				new Answer()
				{
					Id = Guid.Parse("9f9493ae-cfd1-415e-99c5-0745a0118bc8"),
					Text = "Fats and Carbohydrates",
					QuestionId = Guid.Parse("0ef6cf36-8764-4924-9b01-5fcc247c96aa")
				},

				//Question: Which vitamin is essential for calcium absorption and bone health?
				new Answer()
				{
					Id = Guid.Parse("1746af68-5392-45ef-8e4b-3727a30ad3e3"),
					Text = "Vitamin C",
					QuestionId = Guid.Parse("4fbd5ee9-c603-4530-a325-0b8c94d87e52")
				},
				new Answer()
				{
					Id = Guid.Parse("742c20f9-e86b-42f5-b4ea-8570e33c72e9"),
					Text = "Vitamin D",
					QuestionId = Guid.Parse("4fbd5ee9-c603-4530-a325-0b8c94d87e52")
				},
				new Answer()
				{
					Id = Guid.Parse("4447cf77-772e-4e12-8e2f-a2f55c90f4d2"),
					Text = "Vitamin A",
					QuestionId = Guid.Parse("4fbd5ee9-c603-4530-a325-0b8c94d87e52")
				},

				//Question: Which mineral is important for oxygen transport in the blood?
				new Answer()
				{
					Id = Guid.Parse("6222fac1-7b03-4910-a689-7389b679e51b"),
					Text = "Iron",
					QuestionId = Guid.Parse("fc987683-272e-4874-9ec0-adbd1d4d43f0")
				},
				new Answer()
				{
					Id = Guid.Parse("d1cedb19-1c10-4f32-a4f2-7631e8036fdc"),
					Text = "Calcium",
					QuestionId = Guid.Parse("fc987683-272e-4874-9ec0-adbd1d4d43f0")
				},
				new Answer()
				{
					Id = Guid.Parse("f3233ca7-7639-490a-85e2-4d5044f0f7ac"),
					Text = "Zinc",
					QuestionId = Guid.Parse("fc987683-272e-4874-9ec0-adbd1d4d43f0")
				},

				//Question: A deficiency in Vitamin C can lead to which condition?
				new Answer()
				{
					Id = Guid.Parse("a744a2a4-b922-4423-a951-243d598c51f8"),
					Text = "Osteoporosis",
					QuestionId = Guid.Parse("1020c72c-9f20-4b04-8523-e2a9dc643ed2")
				},
				new Answer()
				{
					Id = Guid.Parse("7a61b1aa-e39a-48c4-8067-c75f5805e716"),
					Text = "Anemia",
					QuestionId = Guid.Parse("1020c72c-9f20-4b04-8523-e2a9dc643ed2")
				},
				new Answer()
				{
					Id = Guid.Parse("3d4e27ab-2849-4260-9788-0a6d80e2b70c"),
					Text = "Scurvy",
					QuestionId = Guid.Parse("1020c72c-9f20-4b04-8523-e2a9dc643ed2")
				},

				//Question: Which group of vitamins is fat-soluble?
				new Answer()
				{
					Id = Guid.Parse("7354444b-3ba1-4ce6-a684-37d5626ab44b"),
					Text = "A, D, E, and K",
					QuestionId = Guid.Parse("af7f8faf-0b47-43a7-bce0-2120af75c39c")
				},
				new Answer()
				{
					Id = Guid.Parse("dc110275-785c-4db3-8102-5da138cbbe8a"),
					Text = "B-complex and Vitamin C",
					QuestionId = Guid.Parse("af7f8faf-0b47-43a7-bce0-2120af75c39c")
				},
				new Answer()
				{
					Id = Guid.Parse("fd23af3d-0ab6-40ff-b9c2-e74860f929f7"),
					Text = "Vitamin B12 and Vitamin C",
					QuestionId = Guid.Parse("af7f8faf-0b47-43a7-bce0-2120af75c39c")
				},

				//Question: Zinc plays an important role in:
				new Answer()
				{
					Id = Guid.Parse("de739138-256a-4f36-8c38-d3e69a8a0f8e"),
					Text = "Wound healing",
					QuestionId = Guid.Parse("6aea4f8b-3785-4027-8532-6592c9436898")
				},
				new Answer()
				{
					Id = Guid.Parse("c93b3b93-1a2a-4835-aadb-8c7040ac1aab"),
					Text = "Building bone density",
					QuestionId = Guid.Parse("6aea4f8b-3785-4027-8532-6592c9436898")
				},
				new Answer()
				{
					Id = Guid.Parse("b21d3b1a-32c7-462a-9a9c-9a0b93f71296"),
					Text = "Oxygen transport",
					QuestionId = Guid.Parse("6aea4f8b-3785-4027-8532-6592c9436898")
				},

				//Question: Which vitamin is primarily produced by the body when exposed to sunlight?
				new Answer()
				{
					Id = Guid.Parse("25ad17db-3019-4574-bc4f-183cef4d394c"),
					Text = "Vitamin C",
					QuestionId = Guid.Parse("99e612f3-3e52-4616-8ea1-19d620463779")
				},
				new Answer()
				{
					Id = Guid.Parse("7336f137-8ef5-40d5-9a59-515889f0bb05"),
					Text = "Vitamin D",
					QuestionId = Guid.Parse("99e612f3-3e52-4616-8ea1-19d620463779")
				},
				new Answer()
				{
					Id = Guid.Parse("5b36f07f-a1fe-4fa8-b5f8-4cdb1813df91"),
					Text = "Vitamin E",
					QuestionId = Guid.Parse("99e612f3-3e52-4616-8ea1-19d620463779")
				},

				//Question: What is one of the main benefits of resistance training?
				new Answer()
				{
					Id = Guid.Parse("4f1c3b7c-b8a9-4cbf-9a69-27b6e12a2bb0"),
					Text = "Increased muscle strength",
					QuestionId = Guid.Parse("3da3629a-ace4-45f2-900b-6c134ba6231b")
				},
				new Answer()
				{
					Id = Guid.Parse("96a7d4c1-0df9-4c59-b3cc-b0a93b5e31a3"),
					Text = "Improved flexibility",
					QuestionId = Guid.Parse("3da3629a-ace4-45f2-900b-6c134ba6231b")
				},
				new Answer()
				{
					Id = Guid.Parse("7c6d4a08-47df-48c8-9d9c-23e4f5b0b8cb"),
					Text = "Better sleep quality",
					QuestionId = Guid.Parse("3da3629a-ace4-45f2-900b-6c134ba6231b")
				},

				//Question: Resistance training can help prevent which age-related condition?
				new Answer()
				{
					Id = Guid.Parse("92e47a29-1671-4c49-b7cb-95b5c9f71624"),
					Text = "Arthritis",
					QuestionId = Guid.Parse("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f")
				},
				new Answer()
				{
					Id = Guid.Parse("d1a2e87a-fbc1-47e0-9c0d-7fc3b5adad3b"),
					Text = "Osteoporosis",
					QuestionId = Guid.Parse("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f")
				},
				new Answer()
				{
					Id = Guid.Parse("f8bb27aa-27c6-4141-97a3-0e2d7bfc0d68"),
					Text = "Alzheimer’s disease",
					QuestionId = Guid.Parse("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f")
				},

				//Question: How does resistance training affect metabolism?
				new Answer()
				{
					Id = Guid.Parse("99ed08ac-d2f2-4696-9cfa-471f89e6e1ae"),
					Text = "It increases resting metabolic rate",
					QuestionId = Guid.Parse("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4")
				},
				new Answer()
				{
					Id = Guid.Parse("2a53f9f5-b8a2-4c7b-a38c-148d8d7c9654"),
					Text = "It decreases calorie burn",
					QuestionId = Guid.Parse("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4")
				},
				new Answer()
				{
					Id = Guid.Parse("b154f07b-5c53-4a9d-bbfa-17489e258db8"),
					Text = "It slows down digestion",
					QuestionId = Guid.Parse("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4")
				},

				//Question: Resistance training can help with fat loss primarily by:
				new Answer()
				{
					Id = Guid.Parse("cfa9b01c-c689-456e-8c85-60dd9d31cf34"),
					Text = "Reducing appetite",
					QuestionId = Guid.Parse("4420dd55-0f57-439b-bc4b-47623fe05e5c")
				},
				new Answer()
				{
					Id = Guid.Parse("c6b6d43b-5eaf-43b2-9e13-35c8c81ebc92"),
					Text = "Improving hydration",
					QuestionId = Guid.Parse("4420dd55-0f57-439b-bc4b-47623fe05e5c")
				},
				new Answer()
				{
					Id = Guid.Parse("8d329f9a-9073-467c-8bb8-7748d7276bb3"),
					Text = "Increasing lean muscle mass",
					QuestionId = Guid.Parse("4420dd55-0f57-439b-bc4b-47623fe05e5c")
				},

				//Question: Which of the following is a mental health benefit of resistance training?
				new Answer()
				{
					Id = Guid.Parse("c7f01db0-19b4-4c64-bb64-f87fdf38ff6c"),
					Text = "Reduced symptoms of depression",
					QuestionId = Guid.Parse("196f6df9-6234-499b-9309-c6b0cd29e349")
				},
				new Answer()
				{
					Id = Guid.Parse("23b32ab0-7c5e-45e0-86dc-3f4315c8a0e7"),
					Text = "Improved memory recall",
					QuestionId = Guid.Parse("196f6df9-6234-499b-9309-c6b0cd29e349")
				},
				new Answer()
				{
					Id = Guid.Parse("37d13c3b-c97c-4edc-8f85-4049a32963de"),
					Text = "Decreased caffeine sensitivity",
					QuestionId = Guid.Parse("196f6df9-6234-499b-9309-c6b0cd29e349")
				},

				//Question: Resistance training improves bone health by:
				new Answer()
				{
					Id = Guid.Parse("86922f5c-4f7f-43d7-81c0-08f697e8fc6d"),
					Text = "Increasing bone density",
					QuestionId = Guid.Parse("734b09f7-245b-43cf-bf1a-87a2ead54981")
				},
				new Answer()
				{
					Id = Guid.Parse("da944b9c-95ec-4b28-b38d-4ac50815f7e4"),
					Text = "Reducing calcium absorption",
					QuestionId = Guid.Parse("734b09f7-245b-43cf-bf1a-87a2ead54981")
				},
				new Answer()
				{
					Id = Guid.Parse("f52e10e0-249d-4cd6-8a5a-52c18b9c2ad7"),
					Text = "Preventing hydration loss",
					QuestionId = Guid.Parse("734b09f7-245b-43cf-bf1a-87a2ead54981")
				},

				//Question: Long-term resistance training can reduce the risk of:
				new Answer()
				{
					Id = Guid.Parse("6b3c55d0-3ec7-4b8c-bc36-9b1c6ac8d3f6"),
					Text = "Type 2 diabetes",
					QuestionId = Guid.Parse("706cec35-8678-40a3-bf08-3f4a001765e5")
				},
				new Answer()
				{
					Id = Guid.Parse("c1587adf-c5f3-4996-a0e8-7c4f92696cf2"),
					Text = "Common cold",
					QuestionId = Guid.Parse("706cec35-8678-40a3-bf08-3f4a001765e5")
				},
				new Answer()
				{
					Id = Guid.Parse("f93b876a-38eb-4052-9f5d-54a58c09f059"),
					Text = "Motion sickness",
					QuestionId = Guid.Parse("706cec35-8678-40a3-bf08-3f4a001765e5")
				},

				//Question: Which primary muscle does the bench press target?
				new Answer()
				{
					Id = Guid.Parse("9f87c20a-60c0-4c3a-8b8c-9abbeed8f761"),
					Text = "Pectoralis major",
					QuestionId = Guid.Parse("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff")
				},
				new Answer()
				{
					Id = Guid.Parse("06dbe57d-c81b-4a2e-9e86-7d2a4bcaf88b"),
					Text = "Quadriceps",
					QuestionId = Guid.Parse("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff")
				},
				new Answer()
				{
					Id = Guid.Parse("d6a6d0bb-92c7-44a3-8e1b-92c08e2d97b7"),
					Text = "Latissimus dorsi",
					QuestionId = Guid.Parse("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff")
				},

				//Question: The squat primarily works which muscle group?
				new Answer()
				{
					Id = Guid.Parse("8e154d3b-1f8b-4ef4-85a5-3014f5ea31c2"),
					Text = "Quadriceps",
					QuestionId = Guid.Parse("f68f4855-4f08-4e5e-9480-497f2e7f70c5")
				},
				new Answer()
				{
					Id = Guid.Parse("11b13c0f-20ea-4d7e-9683-4c8e20b508b9"),
					Text = "Triceps",
					QuestionId = Guid.Parse("f68f4855-4f08-4e5e-9480-497f2e7f70c5")
				},
				new Answer()
				{
					Id = Guid.Parse("38cc1c61-87ee-47ff-80bb-15d90a6dc7a1"),
					Text = "Deltoids",
					QuestionId = Guid.Parse("f68f4855-4f08-4e5e-9480-497f2e7f70c5")
				},

				//Question: Deadlifts primarily target:
				new Answer()
				{
					Id = Guid.Parse("af83a62c-84ea-4d8c-a5e4-28c283e8b0f2"),
					Text = "Biceps",
					QuestionId = Guid.Parse("da4b1734-79df-4b91-a69f-7c52b4b7553a")
				},
				new Answer()
				{
					Id = Guid.Parse("f83a6d41-2405-4c38-8b64-546e61d8c6fc"),
					Text = "Posterior chain (glutes, hamstrings, lower back)",
					QuestionId = Guid.Parse("da4b1734-79df-4b91-a69f-7c52b4b7553a")
				},
				new Answer()
				{
					Id = Guid.Parse("c1b89a5c-47f6-4193-bb4e-5e2e6e31b6a2"),
					Text = "Forearms only",
					QuestionId = Guid.Parse("da4b1734-79df-4b91-a69f-7c52b4b7553a")
				},

				//Question: Pull-ups primarily strengthen which muscle group?
				new Answer()
				{
					Id = Guid.Parse("bbbf52d1-d379-4b59-a63f-38b611897b93"),
					Text = "Latissimus dorsi",
					QuestionId = Guid.Parse("b6d72991-5934-4d11-8c64-2144493e4fc6")
				},
				new Answer()
				{
					Id = Guid.Parse("8a1e3735-b9f4-4176-9f87-c88228b43c74"),
					Text = "Calves",
					QuestionId = Guid.Parse("b6d72991-5934-4d11-8c64-2144493e4fc6")
				},
				new Answer()
				{
					Id = Guid.Parse("6f3c6c9d-1e53-4f0d-a72d-23613291c584"),
					Text = "Glutes",
					QuestionId = Guid.Parse("b6d72991-5934-4d11-8c64-2144493e4fc6")
				},

				//Question: Which exercise is best for isolating the biceps?
				new Answer()
				{
					Id = Guid.Parse("5b1d3a91-2d5f-44cb-8e0d-3904a04d3a3d"),
					Text = "Bicep curls",
					QuestionId = Guid.Parse("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e")
				},
				new Answer()
				{
					Id = Guid.Parse("0b78db0e-50c7-41d7-91e4-96f2fa8249d5"),
					Text = "Bench press",
					QuestionId = Guid.Parse("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e")
				},
				new Answer()
				{
					Id = Guid.Parse("7dc67f43-78d5-472c-88de-ff6a8284ec8b"),
					Text = "Leg extensions",
					QuestionId = Guid.Parse("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e")
				},

				//Question: Which muscle is primarily targeted by the overhead shoulder press?
				new Answer()
				{
					Id = Guid.Parse("e85b7430-2a92-4dbd-99c2-9d3c1675a9b4"),
					Text = "Hamstrings",
					QuestionId = Guid.Parse("8b071bdd-25b1-4ab2-9c64-32e44e2eb889")
				},
				new Answer()
				{
					Id = Guid.Parse("d5e0a8e0-50a4-49a4-8c7a-2c771a8280cf"),
					Text = "Pectorals",
					QuestionId = Guid.Parse("8b071bdd-25b1-4ab2-9c64-32e44e2eb889")
				},
				new Answer()
				{
					Id = Guid.Parse("8c5dcaaa-96a0-4267-9eb6-b94ec78e0f7a"),
					Text = "Deltoids",
					QuestionId = Guid.Parse("8b071bdd-25b1-4ab2-9c64-32e44e2eb889")
				},

				//Question: Lunges are most effective for strengthening:
				new Answer()
				{
					Id = Guid.Parse("905c0a9e-9e27-4709-94c6-83a8bcbe84ef"),
					Text = "Triceps",
					QuestionId = Guid.Parse("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b")
				},
				new Answer()
				{
					Id = Guid.Parse("aef3c9d5-9e37-45d2-9ec0-b9e2d9c16e60"),
					Text = "Quadriceps and glutes",
					QuestionId = Guid.Parse("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b")
				},
				new Answer()
				{
					Id = Guid.Parse("2928b832-58ae-4263-8f93-d0f7c76f1c7c"),
					Text = "Forearms",
					QuestionId = Guid.Parse("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b")
				},

				//Question: What is a “training split” in fitness?
				new Answer()
				{
					Id = Guid.Parse("4e32c960-39e4-4fd0-87c1-6b5645d1a0f2"),
					Text = "A way of dividing workouts by muscle groups or days",
					QuestionId = Guid.Parse("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e")
				},
				new Answer()
				{
					Id = Guid.Parse("a0e1c9f7-3e87-4fd6-8a38-59b06f1e9935"),
					Text = "A supplement program",
					QuestionId = Guid.Parse("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e")
				},
				new Answer()
				{
					Id = Guid.Parse("8c417a1b-2182-4668-8ff3-79c0b9c520f0"),
					Text = "A type of diet plan",
					QuestionId = Guid.Parse("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e")
				},

				//Question: Which is a common beginner-friendly training split?
				new Answer()
				{
					Id = Guid.Parse("9f0c9cf0-c5e6-46f4-9c36-134d962a28f9"),
					Text = "Full-body workouts 3x per week",
					QuestionId = Guid.Parse("39d43280-d51f-4a8e-921f-97b6f4b2873e")
				},
				new Answer()
				{
					Id = Guid.Parse("c60ea236-991f-4b8d-bdad-d60f3035eb47"),
					Text = "Two-a-day workouts every day",
					QuestionId = Guid.Parse("39d43280-d51f-4a8e-921f-97b6f4b2873e")
				},
				new Answer()
				{
					Id = Guid.Parse("f5a53d22-1f93-4c4d-9b0f-26384913ad88"),
					Text = "Only training arms and chest",
					QuestionId = Guid.Parse("39d43280-d51f-4a8e-921f-97b6f4b2873e")
				},

				//Question: How many times per week should a beginner ideally train each muscle group?
				new Answer()
				{
					Id = Guid.Parse("5ec2107b-82eb-4721-bbbc-62aa5d1af6c3"),
					Text = "2–3 times per week",
					QuestionId = Guid.Parse("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72")
				},
				new Answer()
				{
					Id = Guid.Parse("0a7fded8-7e67-44cd-896f-49d04743d0c0"),
					Text = "Once every 3 weeks",
					QuestionId = Guid.Parse("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72")
				},
				new Answer()
				{
					Id = Guid.Parse("cd24964d-31fc-4c0d-88e4-1b3d73e3089e"),
					Text = "Every single day",
					QuestionId = Guid.Parse("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72")
				},

				//Question: What is the main advantage of a full-body workout split?
				new Answer()
				{
					Id = Guid.Parse("3f785bfc-8c15-4a69-924c-9bbff78a6a3e"),
					Text = "You only ever train arms",
					QuestionId = Guid.Parse("7a37747e-9f9c-4d6d-a25a-10ee17d64a09")
				},
				new Answer()
				{
					Id = Guid.Parse("a07312e1-9b6c-46c4-90bb-49c1386e9122"),
					Text = "Higher training frequency for all muscles",
					QuestionId = Guid.Parse("7a37747e-9f9c-4d6d-a25a-10ee17d64a09")
				},
				new Answer()
				{
					Id = Guid.Parse("e6d57d8e-93c7-4f87-87e8-82b06419b8e5"),
					Text = "It requires no rest days",
					QuestionId = Guid.Parse("7a37747e-9f9c-4d6d-a25a-10ee17d64a09")
				},

				//Question: Which training split is best for maximizing recovery while still training frequently?
				new Answer()
				{
					Id = Guid.Parse("7c66cb38-1a4c-4c36-9b8a-f0a632cd208f"),
					Text = "Upper/lower body split",
					QuestionId = Guid.Parse("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb")
				},
				new Answer()
				{
					Id = Guid.Parse("d1df8f19-9a92-48fb-83c2-7c3ab2cfb6e7"),
					Text = "Training the same muscle twice a day",
					QuestionId = Guid.Parse("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb")
				},
				new Answer()
				{
					Id = Guid.Parse("73f29d9c-3b3d-47e8-becf-f48792fc48b1"),
					Text = "Never taking rest days",
					QuestionId = Guid.Parse("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb")
				},

				//Question: Why is rest important between training sessions for the same muscle group?
				new Answer()
				{
					Id = Guid.Parse("9f4ebdb2-8c66-44d7-9b82-cae48c90e354"),
					Text = "Rest burns more calories",
					QuestionId = Guid.Parse("f35e77c4-447c-46f3-893e-62110c2ff969")
				},
				new Answer()
				{
					Id = Guid.Parse("88df17df-158d-4c8a-bae0-3adf42c2f9b4"),
					Text = "Rest reduces flexibility",
					QuestionId = Guid.Parse("f35e77c4-447c-46f3-893e-62110c2ff969")
				},
				new Answer()
				{
					Id = Guid.Parse("f88a1ed1-8d71-4d61-a0bb-d91e9b3d0c3f"),
					Text = "Muscles grow and repair during rest",
					QuestionId = Guid.Parse("f35e77c4-447c-46f3-893e-62110c2ff969")
				},

				//Question: An advanced lifter looking to focus on lagging muscle groups might benefit most from:
				new Answer()
				{
					Id = Guid.Parse("fb61ab9f-6f1f-4d25-97dc-44ff1660d4e4"),
					Text = "Only doing cardio",
					QuestionId = Guid.Parse("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea")
				},
				new Answer()
				{
					Id = Guid.Parse("ace71c5c-f9f3-49cc-b229-5d54f46f04d0"),
					Text = "Reducing training volume for non-lagging muscles and increasing frequency for lagging ones",
					QuestionId = Guid.Parse("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea")
				},
				new Answer()
				{
					Id = Guid.Parse("93d0589e-c246-40f0-8f1f-f0a23f00db38"),
					Text = "Never training weak muscles",
					QuestionId = Guid.Parse("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea")
				},

				//Question: What is a compound movement?
				new Answer()
				{
					Id = Guid.Parse("e15973be-d5b9-4db0-8a25-8fbcb18d80cf"),
					Text = "An exercise that works multiple muscle groups and joints",
					QuestionId = Guid.Parse("04ecf251-b526-4445-a6f6-a6c7dfdd586a")
				},
				new Answer()
				{
					Id = Guid.Parse("3442f926-7bc4-4d93-b93e-205f39c5c24f"),
					Text = "An exercise that only works one muscle",
					QuestionId = Guid.Parse("04ecf251-b526-4445-a6f6-a6c7dfdd586a")
				},
				new Answer()
				{
					Id = Guid.Parse("6c83c42a-91ee-4266-9a52-c6a11e58f5d9"),
					Text = "A stretching routine",
					QuestionId = Guid.Parse("04ecf251-b526-4445-a6f6-a6c7dfdd586a")
				},

				//Question: Which of the following is an example of a compound movement?
				new Answer()
				{
					Id = Guid.Parse("ed8fd22a-57e2-42d5-8238-7e6ef1537f12"),
					Text = "Squat",
					QuestionId = Guid.Parse("ed946370-816b-4175-bfee-cc24d3d3c971")
				},
				new Answer()
				{
					Id = Guid.Parse("f5ac49d1-50a3-49f6-bf7f-52ffdfd2781a"),
					Text = "Bicep curl",
					QuestionId = Guid.Parse("ed946370-816b-4175-bfee-cc24d3d3c971")
				},
				new Answer()
				{
					Id = Guid.Parse("d1d77957-0c67-44ff-a89c-c6bc6a267e94"),
					Text = "Calf raise",
					QuestionId = Guid.Parse("ed946370-816b-4175-bfee-cc24d3d3c971")
				},

				//Question: Which of the following is an isolation exercise?
				new Answer()
				{
					Id = Guid.Parse("86cc5df9-62ad-4625-92f3-2145e1b4bfa3"),
					Text = "Deadlift",
					QuestionId = Guid.Parse("562c6f2d-4216-4f46-b74b-a764a7ad5418")
				},
				new Answer()
				{
					Id = Guid.Parse("9d52f7a2-3538-4d07-b633-08c9334504e8"),
					Text = "Bicep curl",
					QuestionId = Guid.Parse("562c6f2d-4216-4f46-b74b-a764a7ad5418")
				},
				new Answer()
				{
					Id = Guid.Parse("cb987d1a-3d49-48a6-bf32-50460e70c002"),
					Text = "Pull-up",
					QuestionId = Guid.Parse("562c6f2d-4216-4f46-b74b-a764a7ad5418")
				},

				//Question: What is the main benefit of compound movements?
				new Answer()
				{
					Id = Guid.Parse("8233a9f1-cfd0-44d7-a16a-8a993f41c292"),
					Text = "They build strength and efficiency by training multiple muscles at once",
					QuestionId = Guid.Parse("a9fced86-bd78-4901-b983-f05a2ad96bcd")
				},
				new Answer()
				{
					Id = Guid.Parse("72af9735-5741-49c2-9bb0-f0f403d14d7d"),
					Text = "They only improve flexibility",
					QuestionId = Guid.Parse("a9fced86-bd78-4901-b983-f05a2ad96bcd")
				},
				new Answer()
				{
					Id = Guid.Parse("22e59af2-67b2-4f33-8728-9c22d4d47a6b"),
					Text = "They isolate single muscles",
					QuestionId = Guid.Parse("a9fced86-bd78-4901-b983-f05a2ad96bcd")
				},

				//Question: Why are isolation exercises useful?
				new Answer()
				{
					Id = Guid.Parse("18c3b8c5-c2fc-40fb-a3b1-1e6ea835edc1"),
					Text = "They burn more calories than compound lifts",
					QuestionId = Guid.Parse("1e3c972d-3549-4d00-8ca5-88ac510abe63")
				},
				new Answer()
				{
					Id = Guid.Parse("90f93384-46e7-48a7-9cd7-7fa246170510"),
					Text = "They replace all compound exercises",
					QuestionId = Guid.Parse("1e3c972d-3549-4d00-8ca5-88ac510abe63")
				},
				new Answer()
				{
					Id = Guid.Parse("f1db93db-420d-4d91-97a5-760312f0a633"),
					Text = "They target specific muscles to correct imbalances or weaknesses",
					QuestionId = Guid.Parse("1e3c972d-3549-4d00-8ca5-88ac510abe63")
				},

				//Question: Which is the best approach for building a balanced physique?
				new Answer()
				{
					Id = Guid.Parse("d67e8c6e-7322-4f30-9382-5d02a64ec230"),
					Text = "Only doing isolation exercises",
					QuestionId = Guid.Parse("2ca88517-a1ad-4bc9-9283-0e4100d60dcd")
				},
				new Answer()
				{
					Id = Guid.Parse("fbbaaf3f-428f-4b60-95d4-5a1f5e0097d6"),
					Text = "Avoiding strength training altogether",
					QuestionId = Guid.Parse("2ca88517-a1ad-4bc9-9283-0e4100d60dcd")
				},
					new Answer()
				{
					Id = Guid.Parse("f9c02ef8-1ed0-44f0-b057-4b8a4a8e97c1"),
					Text = "A mix of compound and isolation exercises",
					QuestionId = Guid.Parse("2ca88517-a1ad-4bc9-9283-0e4100d60dcd")
				},

				//Question: Why are compound lifts often performed at the beginning of a workout?
				new Answer()
				{
					Id = Guid.Parse("be0f259c-c282-4c5c-bf45-27d9d7468f7d"),
					Text = "They require the most energy and proper form",
					QuestionId = Guid.Parse("905e3202-c416-470b-8e11-ce66a9f7a534")
				},
				new Answer()
				{
					Id = Guid.Parse("98a3c6ab-b313-4967-9176-6713db26e22f"),
					Text = "They are easier when you’re already fatigued",
					QuestionId = Guid.Parse("905e3202-c416-470b-8e11-ce66a9f7a534")
				},
				new Answer()
				{
					Id = Guid.Parse("e4236c35-458f-41d4-96a8-4f7ec5f31a84"),
					Text = "They take the least focus and technique",
					QuestionId = Guid.Parse("905e3202-c416-470b-8e11-ce66a9f7a534")
				},

				//Question: Why is recovery important after training?
				new Answer()
				{
					Id = Guid.Parse("6db1e63d-9c8d-42a1-975a-2e4c91f55f2d"),
					Text = "It allows muscles to repair and grow stronger",
					QuestionId = Guid.Parse("018a8f7d-e12b-49d5-8718-889aa668cafb")
				},
				new Answer()
				{
					Id = Guid.Parse("e4e9aa20-b264-4300-8a6c-7cfde77a2f35"),
					Text = "It prevents overtraining and reduces injury risk",
					QuestionId = Guid.Parse("018a8f7d-e12b-49d5-8718-889aa668cafb")
				},
				new Answer()
				{
					Id = Guid.Parse("f6ab422b-92a5-42c7-8de0-2b6a2f7652f8"),
					Text = "It helps restore energy levels",
					QuestionId = Guid.Parse("018a8f7d-e12b-49d5-8718-889aa668cafb")
				},

				//Question: Which of the following is a type of active recovery?
				new Answer()
				{
					Id = Guid.Parse("40fce5c7-61c6-44de-b0f7-902f64e1d6f5"),
					Text = "Light jogging",
					QuestionId = Guid.Parse("d3207231-b15e-428f-b6e7-ab53471202af")
				},
				new Answer()
				{
					Id = Guid.Parse("f62e6f83-ec58-48c0-8610-56c3ff593eb2"),
					Text = "Yoga",
					QuestionId = Guid.Parse("d3207231-b15e-428f-b6e7-ab53471202af")
				},
				new Answer()
				{
					Id = Guid.Parse("96dfaf70-57dc-4210-99e5-f3b7dc9d8415"),
					Text = "Walking",
					QuestionId = Guid.Parse("d3207231-b15e-428f-b6e7-ab53471202af")
				},

				//Question: How many hours of sleep are generally recommended for optimal recovery?
				new Answer()
				{
					Id = Guid.Parse("c4d9784f-7d60-4fdc-858a-71af0a3f3a18"),
					Text = "7–9 hours",
					QuestionId = Guid.Parse("6632e20e-4ff2-4342-8af2-698acaf6e495")
				},
				new Answer()
				{
					Id = Guid.Parse("b41f3261-24f1-44b5-8bdb-8f8c65ebf9b0"),
					Text = "4–5 hours",
					QuestionId = Guid.Parse("6632e20e-4ff2-4342-8af2-698acaf6e495")
				},
				new Answer()
				{
					Id = Guid.Parse("5c1e34a4-36f1-46c8-98e4-efc6d2872183"),
					Text = "10–12 hours",
					QuestionId = Guid.Parse("6632e20e-4ff2-4342-8af2-698acaf6e495")
				},

				//Question: What is a deload week?
				new Answer()
				{
					Id = Guid.Parse("2d8378db-6883-4c42-9620-6789e7cc1799"),
					Text = "A week of complete rest from all activity",
					QuestionId = Guid.Parse("5f83b77f-09eb-43ab-aac6-1ba1a74a8225")
				},
				new Answer()
				{
					Id = Guid.Parse("7d8f3079-46dc-4a3f-a69d-5ad1a7bbf79a"),
					Text = "A planned reduction in training intensity and volume",
					QuestionId = Guid.Parse("5f83b77f-09eb-43ab-aac6-1ba1a74a8225")
				},
				new Answer()
				{
					Id = Guid.Parse("fdf93c0f-1c62-4b9f-9353-15a3eea63d60"),
					Text = "A week focused only on cardio",
					QuestionId = Guid.Parse("5f83b77f-09eb-43ab-aac6-1ba1a74a8225")
				},

				//Question: Which nutrient is particularly important for muscle repair?
				new Answer()
				{
					Id = Guid.Parse("3b7ec122-1ed4-408f-a60c-23d1de8ccf9f"),
					Text = "Protein",
					QuestionId = Guid.Parse("6c611141-34e9-4ae5-892c-27106d39782d")
				},
				new Answer()
				{
					Id = Guid.Parse("939df267-6639-46f3-bf5d-29134815ebf8"),
					Text = "Vitamin D",
					QuestionId = Guid.Parse("6c611141-34e9-4ae5-892c-27106d39782d")
				},
				new Answer()
				{
					Id = Guid.Parse("0ae26420-95f0-4042-9274-3efb35d6f282"),
					Text = "Magnesium",
					QuestionId = Guid.Parse("6c611141-34e9-4ae5-892c-27106d39782d")
				},

				//Question: Which of the following can negatively affect recovery?
				new Answer()
				{
					Id = Guid.Parse("7d2f9e7f-4171-45d6-9ed9-1d4da7cbf4c7"),
					Text = "Chronic stress",
					QuestionId = Guid.Parse("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062")
				},
				new Answer()
				{
					Id = Guid.Parse("47836262-2b8f-42d3-a92c-9c07f87ecf0a"),
					Text = "Sleep deprivation",
					QuestionId = Guid.Parse("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062")
				},
				new Answer()
				{
					Id = Guid.Parse("0ed7b430-4a62-47f7-8997-1cbb3a6b4c1a"),
					Text = "Poor nutrition",
					QuestionId = Guid.Parse("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062")
				},

				//Question: Which strategy helps reduce delayed onset muscle soreness (DOMS)?
				new Answer()
				{
					Id = Guid.Parse("0a66cfa9-ef59-4f3c-a10a-9c22a76e6916"),
					Text = "Foam rolling",
					QuestionId = Guid.Parse("27365168-3b26-4638-927a-0a0d32108cd7")
				},
				new Answer()
				{
					Id = Guid.Parse("9f6a55dc-d7de-4d67-ae8e-8220700dcd55"),
					Text = "Gentle stretching",
					QuestionId = Guid.Parse("27365168-3b26-4638-927a-0a0d32108cd7")
				},
				new Answer()
				{
					Id = Guid.Parse("93d9adcf-5c78-47d7-bc3b-84d8473f6c5d"),
					Text = "Active recovery workouts",
					QuestionId = Guid.Parse("27365168-3b26-4638-927a-0a0d32108cd7")
				},
			});
		}
	}
}
