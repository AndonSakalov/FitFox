using FitFox.Data.Models.MappingModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations.MappingConfigurations
{
	public class UserLessonConfiguration : IEntityTypeConfiguration<UserLesson>
	{
		public void Configure(EntityTypeBuilder<UserLesson> builder)
		{
			builder.HasKey(ul => new { ul.UserId, ul.LessonId });

			builder.HasOne(ul => ul.User)
				.WithMany(ul => ul.UserLessons)
				.HasForeignKey(ul => ul.UserId);

			builder.HasOne(ul => ul.Lesson)
				.WithMany(ul => ul.LessonUsers)
				.HasForeignKey(ul => ul.LessonId);
		}
	}
}
