using FitFox.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations
{
	public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
	{
		public void Configure(EntityTypeBuilder<Lesson> builder)
		{
			builder.HasData(new List<Lesson>()
			{
				//Nutrition:
				new Lesson()
				{
					Id = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834"),
					Title = "Macronutrients",
					MapId = Guid.Parse("04493112-8b84-43be-b926-5a32c5524ac2"),
					OrderNumber = 1,
					XP = 100,
				},
				new Lesson()
				{
					Id = Guid.Parse("97300d33-6cc5-48ba-b495-ff21d5b16419"),
					Title = "Macronutrient Ratios",
					MapId = Guid.Parse("04493112-8b84-43be-b926-5a32c5524ac2"),
					OrderNumber = 2,
					XP = 100,
				},
				new Lesson()
				{
					Id = Guid.Parse("98479667-cd5b-4953-a442-de348acda994"),
					Title = "Hydration and Electrolytes",
					MapId = Guid.Parse("04493112-8b84-43be-b926-5a32c5524ac2"),
					OrderNumber = 5,
					XP = 100,
				},
				new Lesson()
				{
					Id = Guid.Parse("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e"),
					Title = "Protein Quality and Timing",
					MapId = Guid.Parse("04493112-8b84-43be-b926-5a32c5524ac2"),
					OrderNumber = 3,
					XP = 100,
				},
				new Lesson()
				{
					Id = Guid.Parse("0491fb6d-5264-4beb-88e6-a247489c4825"),
					Title = "Micronutrients",
					MapId = Guid.Parse("04493112-8b84-43be-b926-5a32c5524ac2"),
					OrderNumber = 4,
					XP = 100,
				},

				//Training

				new Lesson()
				{
					Id = Guid.Parse("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"),
					Title = "Benefits of Resistance Training",
					MapId = Guid.Parse("1AFE12EA-606D-49D0-ADB9-5F8311D86618"),
					OrderNumber = 1,
					XP = 100,
				},
				new Lesson()
				{
					Id = Guid.Parse("cde73646-a8fb-4131-9308-8269ea662c54"),
					Title = "Exercises and Muscles Targeted",
					MapId = Guid.Parse("1AFE12EA-606D-49D0-ADB9-5F8311D86618"),
					OrderNumber = 2,
					XP = 100,
				},
				new Lesson()
				{
					Id = Guid.Parse("8e10a739-c7a9-4c9e-887c-b2599be94f3a"),
					Title = "Training Splits and Frequency",
					MapId = Guid.Parse("1AFE12EA-606D-49D0-ADB9-5F8311D86618"),
					OrderNumber = 3,
					XP = 100,
				},
				new Lesson()
				{
					Id = Guid.Parse("81476c31-4e91-41d5-b37e-422e97b5882e"),
					Title = "Compound vs Isolation Movements",
					MapId = Guid.Parse("1AFE12EA-606D-49D0-ADB9-5F8311D86618"),
					OrderNumber = 4,
					XP = 100,
				},
				new Lesson()
				{
					Id = Guid.Parse("7e065ddc-a469-4bbe-b205-113c3d96f4c5"),
					Title = "Recovery and Rest",
					MapId = Guid.Parse("1AFE12EA-606D-49D0-ADB9-5F8311D86618"),
					OrderNumber = 5,
					XP = 100,
				},
			});
		}
	}
}
