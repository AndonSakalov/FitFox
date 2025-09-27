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
				new Lesson()
				{
					Id = Guid.Parse("26a98b9c-2a98-4714-8d28-99f6ed419834"),
					Title = "Macronutrients",
					MapId = Guid.Parse("04493112-8b84-43be-b926-5a32c5524ac2"),
					OrderNumber = 1,
					XP = 100,
				}
			});
		}
	}
}
