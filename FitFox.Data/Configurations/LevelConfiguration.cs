using FitFox.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations
{
	public class LevelConfiguration : IEntityTypeConfiguration<Level>
	{
		public void Configure(EntityTypeBuilder<Level> builder)
		{
			var level1Id = Guid.Parse("11111111-1111-1111-1111-111111111111");
			builder.HasData(new Level
			{
				Id = level1Id,
				LevelNumber = 1,
				RequiredXP = 0,
				LevelTitle = "Newbie"
			});
		}
	}
}
