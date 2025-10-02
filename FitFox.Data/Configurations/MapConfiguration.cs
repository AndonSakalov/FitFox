using FitFox.Data.Models;
using FitFox.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations
{
	public class MapConfiguration : IEntityTypeConfiguration<Map>
	{
		public void Configure(EntityTypeBuilder<Map> builder)
		{
			builder.HasData(new Map
			{

				Id = Guid.Parse("1afe12ea-606d-49d0-adb9-5f8311d86618"),
				MapCategory = MapCategory.Training,
				Title = "Training",
				Description = "The basics of training with weights.",
			},
			new Map
			{
				Id = Guid.Parse("04493112-8b84-43be-b926-5a32c5524ac2"),
				MapCategory = MapCategory.Nutrition,
				Title = "Nutrition",
				Description = "The basics of nutrition focused on gym progression."
			}
		);
		}
	}
}

