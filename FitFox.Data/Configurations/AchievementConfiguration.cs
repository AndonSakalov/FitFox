using FitFox.Data.Models;
using FitFox.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static FitFox.Common.Descriptions.AchievementDescriptions;
using static FitFox.Common.ImageURLs.AchievementImageURLs;
using static FitFox.Common.Titles.AchievementTitles;
namespace FitFox.Data.Configurations
{
	public class AchievementConfiguration : IEntityTypeConfiguration<Achievement>
	{
		public void Configure(EntityTypeBuilder<Achievement> builder)
		{
			builder.HasData(new List<Achievement>()
			{
				new Achievement()
				{
					Id = Guid.Parse("4c1f8a22-7e0b-4c13-bc38-2f4b9f7a1d90"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.LessonsLearned,
					ConditionValue = 1,
					Title = FirstLessonAchievementTitle,
					Description = FirstLessonLearnedAchievementDescription
				},
				new Achievement()
				{
					Id = Guid.Parse("af2d9e71-3b54-4c8c-a8c5-9e2f38d12a44"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.MapsCovered,
					ConditionValue = 50,
					Title = HalfMapCoverageAchievementTitle,
					Description = HalfMapCoverageAchievementDescription
				},
				new Achievement()
				{
					Id = Guid.Parse("17e94d55-2c88-4a63-bc41-6e7fb922e3c1"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.MapsCovered,
					ConditionValue = 100,
					Title = FullMapCoverageAchievementTitle,
					Description = FullMapCoverageAchievementDescription
				},
				new Achievement()
				{
					Id = Guid.Parse("d8b0309a-bc74-4fa8-bb13-0f1c3c9e5a22"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.DailyQuestsCompleted,
					ConditionValue = 1,
					Title = DailyQuestCompletedAchievementTitle,
					Description = FirstDailyQuestAchievementDescription,
				},
				new Achievement()
				{
					Id = Guid.Parse("623fa9e8-0b67-4c20-b862-f2d240679cb1"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.DailyQuestsCompleted,
					ConditionValue = 5,
					Title = FiveDailyQuestsCompletedAchievementTitle,
					Description = FiveDailyQuestsCompletedAchievementTitle,
				},
				new Achievement()
				{
					Id = Guid.Parse("b28e13d4-6cb9-4ad1-9869-eaf0c1870ec3"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.DailyQuestsCompleted,
					ConditionValue = 10,
					Title = TenDailyQuestsCompletedAchievementTitle,
					Description = TenDailyQuestsAchievementDescription
				},
				new Achievement()
				{
					Id = Guid.Parse("94c5d27e-8ee4-4fc4-a9df-36bcfb85ea48"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.LessonsLearned,
					ConditionValue = 5,
					Title = FiveLessonsPassedAchievementTitle,
					Description = FiveLessonsLearnedAchievementDescription
				},
				new Achievement()
				{
					Id = Guid.Parse("f6b7903a-41e0-4753-9ad0-d8ac584c5c6f"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.LessonsLearned,
					ConditionValue = 10,
					Title = TenLessonsPassedAchievementTitle,
					Description = TenLessonsLearnedAchievementDescription
				},
				new Achievement()
				{
					Id = Guid.Parse("2f0cc148-2fa5-4f04-bfc6-0e3d139a9f52"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.MapsCovered,
					ConditionValue = 2,
					Title = TwoMapsPassedAchievementTitle,
					Description = TwoMapsPassedAchievementDescription
				},
				new Achievement()
				{
					Id = Guid.Parse("cd4a6277-0f39-4b24-b86c-167ccc0a5b61"),
					IconUrl = NoImgImg,
					ConditionType = ConditionType.LevelsReached,
					ConditionValue = 5,
					Title = ReachLevelFiveAchievementTitle,
					Description = ReachLevelFiveAchievementDescription
				},

			});
		}
	}
}
