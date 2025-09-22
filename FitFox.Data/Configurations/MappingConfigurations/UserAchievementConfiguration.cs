using FitFox.Data.Models.MappingModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations.MappingConfigurations
{
	public class UserAchievementConfiguration : IEntityTypeConfiguration<UserAchievement>
	{
		public void Configure(EntityTypeBuilder<UserAchievement> builder)
		{
			builder.HasKey(ua => new { ua.UserId, ua.AchievementId });

			builder.HasOne(ua => ua.User)
				.WithMany(ua => ua.UserAchievements)
				.HasForeignKey(ua => ua.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(ua => ua.Achievement)
				.WithMany(ua => ua.AchievementUsers)
				.HasForeignKey(ua => ua.AchievementId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
