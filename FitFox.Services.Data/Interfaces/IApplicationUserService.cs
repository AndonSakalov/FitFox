using FitFox.Web.ViewModels.Achievement;
using FitFox.Web.ViewModels.Player;

namespace FitFox.Services.Data.Interfaces
{
	public interface IApplicationUserService
	{
		Task StartMapForUserAsync(Guid mapId, Guid userId);

		Task MarkLessonAsPassed(Guid lessonId, Guid userId);

		Task<PlayerInfo> FetchUserInfoAsync(Guid userId);

		Task<bool> GrantUserXp(Guid userId, Guid lessonId);

		Task<bool> TryLevelUp(Guid userId);

		Task<(bool isSuccessful, IEnumerable<AchievementGrantedViewModel> achievementsGranted)> CheckForAchievementsToGrantAsync(Guid userId);

		Task<bool> UpdateMapCoverage(Guid userId, Guid lessonId);
	}
}
