using FitFox.Data.Models.MappingModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations.MappingConfigurations
{
	public class UserMapConfiguration : IEntityTypeConfiguration<UserMap>
	{
		public void Configure(EntityTypeBuilder<UserMap> builder)
		{
			builder.HasKey(um => new { um.UserId, um.MapId });

			builder.HasOne(um => um.User)
				.WithMany(um => um.UserMaps)
				.HasForeignKey(um => um.UserId);

			builder.HasOne(um => um.Map)
				.WithMany(um => um.MapUsers)
				.HasForeignKey(um => um.MapId);
		}
	}
}
