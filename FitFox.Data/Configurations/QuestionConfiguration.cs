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

				//Lesson: Macronutrients
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
					},

				//Lesson: Macronutrient Ratios
					new Question()
					{
						Id = Guid.Parse("725ac1b4-5362-484a-964a-4a1bc95a2aab"),
						Text = "What is the typical protein intake per kg of body weight for a person trying to build muscle?",
						CorrectAnswerId = Guid.Parse("3c3fd6c5-5c2d-4ef4-b2a3-fdf7f4d7dc94"),
						LessonId = Guid.Parse("97300d33-6cc5-48ba-b495-ff21d5b16419")
					},
					new Question()
					{
						Id = Guid.Parse("ab0fda0c-dca4-4b12-a690-8e1b311ee5de"),
						Text = "For a cutting diet, which macronutrient is often reduced first?",
						CorrectAnswerId = Guid.Parse("0f9d15b7-8b2f-4df7-8613-93d80d3d3c34"),
						LessonId = Guid.Parse("97300d33-6cc5-48ba-b495-ff21d5b16419")
					},
					new Question()
					{
						Id = Guid.Parse("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4"),
						Text = "Which macronutrient is usually prioritized for muscle gain?",
						CorrectAnswerId = Guid.Parse("6c44c89a-c257-4cd5-8653-c3f523b42f15"),
						LessonId = Guid.Parse("97300d33-6cc5-48ba-b495-ff21d5b16419")
					},
					new Question()
					{
						Id = Guid.Parse("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee"),
						Text = "For someone on a low-carb diet, which macronutrient is usually increased to compensate for reduced carbs?",
						CorrectAnswerId = Guid.Parse("f3c7b58d-8fbb-4d6e-b2f5-3e6f2d9a7b21"),
						LessonId = Guid.Parse("97300d33-6cc5-48ba-b495-ff21d5b16419")
					},

				//Lesson:  Hydration and Electrolytes
					new Question()
					{
						Id = Guid.Parse("c29ae0bc-eb61-45c1-be09-2e24ca66862b"),
						Text = "What is the main function of water in the body?",
						CorrectAnswerId = Guid.Parse("a8e4f0c5-5a2c-4e2e-98d1-0f7bfa36c1b7"),
						LessonId = Guid.Parse("98479667-cd5b-4953-a442-de348acda994")
					},
					new Question()
					{
						Id = Guid.Parse("d76f8572-c76d-4ea6-96e2-88f94b2ef5db"),
						Text = "Which electrolyte is most important for muscle contraction and nerve function?",
						CorrectAnswerId = Guid.Parse("d0c6a5e2-3c2b-4f85-8ed2-1a9b6c7d4f2a"),
						LessonId = Guid.Parse("98479667-cd5b-4953-a442-de348acda994")
					},
					new Question()
					{
						Id = Guid.Parse("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90"),
						Text = "Which electrolyte helps regulate heart rhythm and fluid balance?",
						CorrectAnswerId = Guid.Parse("b8f7d3c4-1a5b-4e8c-9d2a-0f4e3c7b2d1a"),
						LessonId = Guid.Parse("98479667-cd5b-4953-a442-de348acda994")
					},
					new Question()
					{
						Id = Guid.Parse("4c550c86-a27f-480d-8a34-26a5d94d7bb3"),
						Text = "A common sign of dehydration is:",
						CorrectAnswerId = Guid.Parse("f1b2d3a4-5e6c-4f8d-9a1b-2c3d4e5f6a7b"),
						LessonId = Guid.Parse("98479667-cd5b-4953-a442-de348acda994")
					},
					new Question()
					{
						Id = Guid.Parse("3b1a72e5-e73e-4e8d-833e-b92a61eb2664"),
						Text = "How many liters of water are generally recommended per day for an average adult?",
						CorrectAnswerId = Guid.Parse("f6a5b4c3-7d8e-4f9a-8b1c-5d6e7f8a9b0c"),
						LessonId = Guid.Parse("98479667-cd5b-4953-a442-de348acda994")
					},
					new Question()
					{
						Id = Guid.Parse("2cd2b95d-63c0-4c7f-9485-3df385a91476"),
						Text = "Which electrolyte is often lost in large amounts through sweat?",
						CorrectAnswerId = Guid.Parse("f0e9d8c7-1b2c-4d3e-9f5a-9b0c1d2e3f4a"),
						LessonId = Guid.Parse("98479667-cd5b-4953-a442-de348acda994")
					},
					new Question()
					{
						Id = Guid.Parse("3bbce0fb-8e12-4a03-837d-9ac269f282ff"),
						Text = "Magnesium helps with all of the following EXCEPT:",
						CorrectAnswerId = Guid.Parse("f4e3d2c1-5b6c-4d8e-9f9d-3f4a5b6c7d8e"),
						LessonId = Guid.Parse("98479667-cd5b-4953-a442-de348acda994")
					},

				//Lesson: Protein Quality and Timing
					new Question()
					{
						Id = Guid.Parse("e74d6670-97b6-42c9-8464-881dbb6bfa9d"),
						Text = "Which protein source is considered “complete”, containing all essential amino acids?",
						CorrectAnswerId = Guid.Parse("c3b1f8a4-2d7e-4b9c-9a1f-0b6d3e5f7a1b"),
						LessonId = Guid.Parse("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e")
					},
					new Question()
					{
						Id = Guid.Parse("b850b9da-babb-465e-96b4-99639f04711e"),
						Text = "When is protein consumption most effective for muscle recovery?",
						CorrectAnswerId = Guid.Parse("b7c8d9e0-1a2b-4c3d-9f4e-3a5b6c7d8e9f"),
						LessonId = Guid.Parse("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e")
					},
					new Question()
					{
						Id = Guid.Parse("34c91eb1-1e3b-4f7b-bf02-8b9f34653023"),
						Text = "Which protein source is faster digesting and ideal post-workout?",
						CorrectAnswerId = Guid.Parse("e0f1a2b3-4d5e-4f6a-8c3d-6d7e8f9a0b1c"),
						LessonId = Guid.Parse("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e")
					},
					new Question()
					{
						Id = Guid.Parse("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794"),
						Text = "Casein protein is best consumed:",
						CorrectAnswerId = Guid.Parse("b3c4d5e6-7f8a-4d9b-9d6e-9a0b1c2d3e4f"),
						LessonId = Guid.Parse("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e")
					},
					new Question()
					{
						Id = Guid.Parse("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5"),
						Text = "Combining different plant proteins can help:",
						CorrectAnswerId = Guid.Parse("e6f7a8b9-0c1d-4d2e-8a9b-2d3e4f5a6b7c"),
						LessonId = Guid.Parse("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e")
					},
				
				//Lesson: Micronutrients
					new Question()
					{
						Id = Guid.Parse("0ef6cf36-8764-4924-9b01-5fcc247c96aa"),
						Text = "Which of the following are considered micronutrients?",
						CorrectAnswerId = Guid.Parse("e8b0b203-90ba-4285-ad9e-493bd3592135"),
						LessonId = Guid.Parse("0491fb6d-5264-4beb-88e6-a247489c4825")
					},
					new Question()
					{
						Id = Guid.Parse("4fbd5ee9-c603-4530-a325-0b8c94d87e52"),
						Text = "Which vitamin is essential for calcium absorption and bone health?",
						CorrectAnswerId = Guid.Parse("742c20f9-e86b-42f5-b4ea-8570e33c72e9"),
						LessonId = Guid.Parse("0491fb6d-5264-4beb-88e6-a247489c4825")
					},
					new Question()
					{
						Id = Guid.Parse("fc987683-272e-4874-9ec0-adbd1d4d43f0"),
						Text = "Which mineral is important for oxygen transport in the blood?",
						CorrectAnswerId = Guid.Parse("6222fac1-7b03-4910-a689-7389b679e51b"),
						LessonId = Guid.Parse("0491fb6d-5264-4beb-88e6-a247489c4825")
					},
					new Question()
					{
						Id = Guid.Parse("1020c72c-9f20-4b04-8523-e2a9dc643ed2"),
						Text = "A deficiency in Vitamin C can lead to which condition?",
						CorrectAnswerId = Guid.Parse("3d4e27ab-2849-4260-9788-0a6d80e2b70c"),
						LessonId = Guid.Parse("0491fb6d-5264-4beb-88e6-a247489c4825")
					},
					new Question()
					{
						Id = Guid.Parse("af7f8faf-0b47-43a7-bce0-2120af75c39c"),
						Text = "Which group of vitamins is fat-soluble?",
						CorrectAnswerId = Guid.Parse("7354444b-3ba1-4ce6-a684-37d5626ab44b"),
						LessonId = Guid.Parse("0491fb6d-5264-4beb-88e6-a247489c4825")
					},
					new Question()
					{
						Id = Guid.Parse("6aea4f8b-3785-4027-8532-6592c9436898"),
						Text = "Zinc plays an important role in:",
						CorrectAnswerId = Guid.Parse("de739138-256a-4f36-8c38-d3e69a8a0f8e"),
						LessonId = Guid.Parse("0491fb6d-5264-4beb-88e6-a247489c4825")
					},
					new Question()
					{
						Id = Guid.Parse("99e612f3-3e52-4616-8ea1-19d620463779"),
						Text = "Which vitamin is primarily produced by the body when exposed to sunlight?",
						CorrectAnswerId = Guid.Parse("7336f137-8ef5-40d5-9a59-515889f0bb05"),
						LessonId = Guid.Parse("0491fb6d-5264-4beb-88e6-a247489c4825")
					},

				//Lesson: Benefits of Resistance Training  
					new Question()
{
						Id = Guid.Parse("3da3629a-ace4-45f2-900b-6c134ba6231b"),
						Text = "What is one of the main benefits of resistance training?",
						CorrectAnswerId = Guid.Parse("4f1c3b7c-b8a9-4cbf-9a69-27b6e12a2bb0"),
						LessonId = Guid.Parse("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7")
					},
					new Question()
					{
						Id = Guid.Parse("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f"),
						Text = "Resistance training can help prevent which age-related condition?",
						CorrectAnswerId = Guid.Parse("d1a2e87a-fbc1-47e0-9c0d-7fc3b5adad3b"),
						LessonId = Guid.Parse("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7")
					},
					new Question()
					{
						Id = Guid.Parse("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4"),
						Text = "How does resistance training affect metabolism?",
						CorrectAnswerId = Guid.Parse("99ed08ac-d2f2-4696-9cfa-471f89e6e1ae"),
						LessonId = Guid.Parse("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7")
					},
					new Question()
					{
						Id = Guid.Parse("4420dd55-0f57-439b-bc4b-47623fe05e5c"),
						Text = "Resistance training can help with fat loss primarily by:",
						CorrectAnswerId = Guid.Parse("8d329f9a-9073-467c-8bb8-7748d7276bb3"),
						LessonId = Guid.Parse("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7")
					},
					new Question()
					{
						Id = Guid.Parse("196f6df9-6234-499b-9309-c6b0cd29e349"),
						Text = "Which of the following is a mental health benefit of resistance training?",
						CorrectAnswerId = Guid.Parse("c7f01db0-19b4-4c64-bb64-f87fdf38ff6c"),
						LessonId = Guid.Parse("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7")
					},
					new Question()
					{
						Id = Guid.Parse("734b09f7-245b-43cf-bf1a-87a2ead54981"),
						Text = "Resistance training improves bone health by:",
						CorrectAnswerId = Guid.Parse("86922f5c-4f7f-43d7-81c0-08f697e8fc6d"),
						LessonId = Guid.Parse("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7")
					},
					new Question()
					{
						Id = Guid.Parse("706cec35-8678-40a3-bf08-3f4a001765e5"),
						Text = "Long-term resistance training can reduce the risk of:",
						CorrectAnswerId = Guid.Parse("6b3c55d0-3ec7-4b8c-bc36-9b1c6ac8d3f6"),
						LessonId = Guid.Parse("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7")
					},

				//Lesson: Exercises and Muscles Targeted
					new Question()
					{
						Id = Guid.Parse("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff"),
						Text = "Which primary muscle does the bench press target?",
						CorrectAnswerId = Guid.Parse("9f87c20a-60c0-4c3a-8b8c-9abbeed8f761"),
						LessonId = Guid.Parse("cde73646-a8fb-4131-9308-8269ea662c54")
					},
					new Question()
					{
						Id = Guid.Parse("f68f4855-4f08-4e5e-9480-497f2e7f70c5"),
						Text = "The squat primarily works which muscle group?",
						CorrectAnswerId = Guid.Parse("8e154d3b-1f8b-4ef4-85a5-3014f5ea31c2"),
						LessonId = Guid.Parse("cde73646-a8fb-4131-9308-8269ea662c54")
					},
					new Question()
					{
						Id = Guid.Parse("da4b1734-79df-4b91-a69f-7c52b4b7553a"),
						Text = "Deadlifts primarily target:",
						CorrectAnswerId = Guid.Parse("f83a6d41-2405-4c38-8b64-546e61d8c6fc"),
						LessonId = Guid.Parse("cde73646-a8fb-4131-9308-8269ea662c54")
					},
					new Question()
					{
						Id = Guid.Parse("b6d72991-5934-4d11-8c64-2144493e4fc6"),
						Text = "Pull-ups primarily strengthen which muscle group?",
						CorrectAnswerId = Guid.Parse("bbbf52d1-d379-4b59-a63f-38b611897b93"),
						LessonId = Guid.Parse("cde73646-a8fb-4131-9308-8269ea662c54")
					},
					new Question()
					{
						Id = Guid.Parse("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e"),
						Text = "Which exercise is best for isolating the biceps?",
						CorrectAnswerId = Guid.Parse("5b1d3a91-2d5f-44cb-8e0d-3904a04d3a3d"),
						LessonId = Guid.Parse("cde73646-a8fb-4131-9308-8269ea662c54")
					},
					new Question()
					{
						Id = Guid.Parse("8b071bdd-25b1-4ab2-9c64-32e44e2eb889"),
						Text = "Which muscle is primarily targeted by the overhead shoulder press?",
						CorrectAnswerId = Guid.Parse("8c5dcaaa-96a0-4267-9eb6-b94ec78e0f7a"),
						LessonId = Guid.Parse("cde73646-a8fb-4131-9308-8269ea662c54")
					},
					new Question()
					{
						Id = Guid.Parse("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b"),
						Text = "Lunges are most effective for strengthening:",
						CorrectAnswerId = Guid.Parse("aef3c9d5-9e37-45d2-9ec0-b9e2d9c16e60"),
						LessonId = Guid.Parse("cde73646-a8fb-4131-9308-8269ea662c54")
					},

				//Lesson: Training Splits and Frequency
					new Question()
					{
						Id = Guid.Parse("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e"),
						Text = "What is a “training split” in fitness?",
						CorrectAnswerId = Guid.Parse("4e32c960-39e4-4fd0-87c1-6b5645d1a0f2"),
						LessonId = Guid.Parse("8e10a739-c7a9-4c9e-887c-b2599be94f3a")
					},
					new Question()
					{
						Id = Guid.Parse("39d43280-d51f-4a8e-921f-97b6f4b2873e"),
						Text = "Which is a common beginner-friendly training split?",
						CorrectAnswerId = Guid.Parse("9f0c9cf0-c5e6-46f4-9c36-134d962a28f9"),
						LessonId = Guid.Parse("8e10a739-c7a9-4c9e-887c-b2599be94f3a")
					},
					new Question()
					{
						Id = Guid.Parse("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72"),
						Text = "How many times per week should a beginner ideally train each muscle group?",
						CorrectAnswerId = Guid.Parse("5ec2107b-82eb-4721-bbbc-62aa5d1af6c3"),
						LessonId = Guid.Parse("8e10a739-c7a9-4c9e-887c-b2599be94f3a")
					},
					new Question()
					{
						Id = Guid.Parse("7a37747e-9f9c-4d6d-a25a-10ee17d64a09"),
						Text = "What is the main advantage of a full-body workout split?",
						CorrectAnswerId = Guid.Parse("a07312e1-9b6c-46c4-90bb-49c1386e9122"),
						LessonId = Guid.Parse("8e10a739-c7a9-4c9e-887c-b2599be94f3a")
					},
					new Question()
					{
						Id = Guid.Parse("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb"),
						Text = "Which training split is best for maximizing recovery while still training frequently?",
						CorrectAnswerId = Guid.Parse("7c66cb38-1a4c-4c36-9b8a-f0a632cd208f"),
						LessonId = Guid.Parse("8e10a739-c7a9-4c9e-887c-b2599be94f3a")
					},
					new Question()
					{
						Id = Guid.Parse("f35e77c4-447c-46f3-893e-62110c2ff969"),
						Text = "Why is rest important between training sessions for the same muscle group?",
						CorrectAnswerId = Guid.Parse("f88a1ed1-8d71-4d61-a0bb-d91e9b3d0c3f"),
						LessonId = Guid.Parse("8e10a739-c7a9-4c9e-887c-b2599be94f3a")
					},
					new Question()
					{
						Id = Guid.Parse("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea"),
						Text = "An advanced lifter looking to focus on lagging muscle groups might benefit most from:",
						CorrectAnswerId = Guid.Parse("ace71c5c-f9f3-49cc-b229-5d54f46f04d0"),
						LessonId = Guid.Parse("8e10a739-c7a9-4c9e-887c-b2599be94f3a")
					},

				//Lesson: Compound vs Isolation Movements
					new Question()
					{
						Id = Guid.Parse("04ecf251-b526-4445-a6f6-a6c7dfdd586a"),
						Text = "What is a compound movement?",
						CorrectAnswerId = Guid.Parse("e15973be-d5b9-4db0-8a25-8fbcb18d80cf"),
						LessonId = Guid.Parse("81476c31-4e91-41d5-b37e-422e97b5882e")
					},
					new Question()
					{
						Id = Guid.Parse("ed946370-816b-4175-bfee-cc24d3d3c971"),
						Text = "Which of the following is an example of a compound movement?",
						CorrectAnswerId = Guid.Parse("ed8fd22a-57e2-42d5-8238-7e6ef1537f12"),
						LessonId = Guid.Parse("81476c31-4e91-41d5-b37e-422e97b5882e")
					},
					new Question()
					{
						Id = Guid.Parse("562c6f2d-4216-4f46-b74b-a764a7ad5418"),
						Text = "Which of the following is an isolation exercise?",
						CorrectAnswerId = Guid.Parse("9d52f7a2-3538-4d07-b633-08c9334504e8"),
						LessonId = Guid.Parse("81476c31-4e91-41d5-b37e-422e97b5882e")
					},
					new Question()
					{
						Id = Guid.Parse("a9fced86-bd78-4901-b983-f05a2ad96bcd"),
						Text = "What is the main benefit of compound movements?",
						CorrectAnswerId = Guid.Parse("8233a9f1-cfd0-44d7-a16a-8a993f41c292"),
						LessonId = Guid.Parse("81476c31-4e91-41d5-b37e-422e97b5882e")
					},
					new Question()
					{
						Id = Guid.Parse("1e3c972d-3549-4d00-8ca5-88ac510abe63"),
						Text = "Why are isolation exercises useful?",
						CorrectAnswerId = Guid.Parse("f1db93db-420d-4d91-97a5-760312f0a633"),
						LessonId = Guid.Parse("81476c31-4e91-41d5-b37e-422e97b5882e")
					},
					new Question()
					{
						Id = Guid.Parse("2ca88517-a1ad-4bc9-9283-0e4100d60dcd"),
						Text = "Which is the best approach for building a balanced physique?",
						CorrectAnswerId = Guid.Parse("f9c02ef8-1ed0-44f0-b057-4b8a4a8e97c1"),
						LessonId = Guid.Parse("81476c31-4e91-41d5-b37e-422e97b5882e")
					},
					new Question()
					{
						Id = Guid.Parse("905e3202-c416-470b-8e11-ce66a9f7a534"),
						Text = "Why are compound lifts often performed at the beginning of a workout?",
						CorrectAnswerId = Guid.Parse("be0f259c-c282-4c5c-bf45-27d9d7468f7d"),
						LessonId = Guid.Parse("81476c31-4e91-41d5-b37e-422e97b5882e")
					},

				//Lesson: Recovery and Rest
					new Question()
					{
						Id = Guid.Parse("018a8f7d-e12b-49d5-8718-889aa668cafb"),
						Text = "Why is recovery important after training?",
						CorrectAnswerId = Guid.Parse("6db1e63d-9c8d-42a1-975a-2e4c91f55f2d"),
						LessonId = Guid.Parse("7e065ddc-a469-4bbe-b205-113c3d96f4c5")
					},
					new Question()
					{
						Id = Guid.Parse("d3207231-b15e-428f-b6e7-ab53471202af"),
						Text = "Which of the following is a type of active recovery?",
						CorrectAnswerId = Guid.Parse("96dfaf70-57dc-4210-99e5-f3b7dc9d8415"),
						LessonId = Guid.Parse("7e065ddc-a469-4bbe-b205-113c3d96f4c5")
					},
					new Question()
					{
						Id = Guid.Parse("6632e20e-4ff2-4342-8af2-698acaf6e495"),
						Text = "How many hours of sleep are generally recommended for optimal recovery?",
						CorrectAnswerId = Guid.Parse("c4d9784f-7d60-4fdc-858a-71af0a3f3a18"),
						LessonId = Guid.Parse("7e065ddc-a469-4bbe-b205-113c3d96f4c5")
					},
					new Question()
					{
						Id = Guid.Parse("5f83b77f-09eb-43ab-aac6-1ba1a74a8225"),
						Text = "What is a deload week?",
						CorrectAnswerId = Guid.Parse("7d8f3079-46dc-4a3f-a69d-5ad1a7bbf79a"),
						LessonId = Guid.Parse("7e065ddc-a469-4bbe-b205-113c3d96f4c5")
					},
					new Question()
					{
						Id = Guid.Parse("6c611141-34e9-4ae5-892c-27106d39782d"),
						Text = "Which nutrient is particularly important for muscle repair?",
						CorrectAnswerId = Guid.Parse("3b7ec122-1ed4-408f-a60c-23d1de8ccf9f"),
						LessonId = Guid.Parse("7e065ddc-a469-4bbe-b205-113c3d96f4c5")
					},
					new Question()
					{
						Id = Guid.Parse("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062"),
						Text = "Which of the following can negatively affect recovery?",
						CorrectAnswerId = Guid.Parse("47836262-2b8f-42d3-a92c-9c07f87ecf0a"),
						LessonId = Guid.Parse("7e065ddc-a469-4bbe-b205-113c3d96f4c5")
					},
					new Question()
					{
						Id = Guid.Parse("27365168-3b26-4638-927a-0a0d32108cd7"),
						Text = "Which strategy helps reduce delayed onset muscle soreness (DOMS)?",
						CorrectAnswerId = Guid.Parse("9f6a55dc-d7de-4d67-ae8e-8220700dcd55"),
						LessonId = Guid.Parse("7e065ddc-a469-4bbe-b205-113c3d96f4c5")
					},
				});
		}
	}
}
