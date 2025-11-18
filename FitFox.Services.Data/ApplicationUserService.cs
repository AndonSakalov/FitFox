using FitFox.Data.Models;
using FitFox.Data.Models.Enums;
using FitFox.Data.Models.MappingModels;
using FitFox.Data.Repository.Interfaces;
using FitFox.Services.Data.Interfaces;
using FitFox.Web.ViewModels.Achievement;
using FitFox.Web.ViewModels.Lesson;
using FitFox.Web.ViewModels.Level;
using FitFox.Web.ViewModels.Map;
using FitFox.Web.ViewModels.Player;
using Microsoft.EntityFrameworkCore;

namespace FitFox.Services.Data
{
	internal class ApplicationUserService : BaseService, IApplicationUserService
	{
		private readonly IRepository<ApplicationUser, Guid> _applicationUserRepository;
		private readonly IRepository<Map, Guid> _mapRepository;
		private readonly IRepository<Lesson, Guid> _lessonRepository;
		private readonly IRepository<Level, Guid> _levelRepository;
		private readonly IRepository<Achievement, Guid> _achievementRepository;

		public ApplicationUserService(
			IRepository<ApplicationUser, Guid> applicationUserRepository,
			IRepository<Map, Guid> mapRepository,
			IRepository<Lesson, Guid> lessonRepository,
			IRepository<Level, Guid> levelRepository,
			IRepository<Achievement, Guid> achievementRepository)
		{
			_applicationUserRepository = applicationUserRepository;
			_mapRepository = mapRepository;
			_lessonRepository = lessonRepository;
			_levelRepository = levelRepository;
			_achievementRepository = achievementRepository;
		}

		public async Task MarkLessonAsPassed(Guid lessonId, Guid userId)
		{
			var user = await _applicationUserRepository.GetAllAttached()
				.Include(u => u.UserLessons)
				.FirstOrDefaultAsync(u => u.Id == userId);

			var lesson = await _lessonRepository.GetByIdAsync(lessonId);

			if (lesson == null || user == null)
			{
				throw new Exception("Lesson or User not found!");
			}

			bool alreadyPassed = user.UserLessons.Any(u => u.LessonId == lessonId);

			if (!alreadyPassed)
			{
				UserLesson userLesson = new UserLesson()
				{
					LessonId = lessonId,
					UserId = userId
				};

				user.UserLessons.Add(userLesson);
				await _applicationUserRepository.UpdateAsync(user); // TODO:bool result
			}
		}

		public async Task StartMapForUserAsync(Guid mapId, Guid userId)
		{
			var user = await _applicationUserRepository.GetAllAttached()
				.Include(u => u.UserMaps)
				.FirstOrDefaultAsync(u => u.Id == userId);

			var map = await _mapRepository.GetByIdAsync(mapId);

			if (map == null || user == null)
			{
				throw new Exception("Map or User not found!");
			}

			bool alreadyStarted = user.UserMaps.Any(m => m.MapId == map.Id);

			if (!alreadyStarted)
			{
				var userMap = new UserMap()
				{
					MapId = mapId,
					UserId = userId,
				};

				user.UserMaps.Add(userMap);
				await _applicationUserRepository.UpdateAsync(user);
			}
		}

		public async Task<PlayerInfo> FetchUserInfoAsync(Guid userId)
		{
			var user = await _applicationUserRepository.GetAllAttached()
				.Include(u => u.UserMaps)
				.ThenInclude(um => um.Map)
				.ThenInclude(m => m.Lessons)
				.Include(u => u.UserLessons)
				.ThenInclude(ul => ul.Lesson)
				.Include(u => u.Level)
				.Include(u => u.UserAchievements)
				.ThenInclude(ua => ua.Achievement)
				.FirstOrDefaultAsync(u => u.Id == userId);

			if (user == null)
			{
				return null;
			}

			var result = new PlayerInfo()
			{
				Id = user.Id,
				Achievements = user.UserAchievements.Select(ua => new AchievementViewModel()
				{
					Id = ua.AchievementId,
					Description = ua.Achievement.Description,
					IconURL = ua.Achievement.IconUrl,
					Title = ua.Achievement.Title,
				}).ToList(),
				CurrentXP = user.CurrentXP,
				CompletedLessons = user.UserLessons.Select(ul => new LessonDisplayViewModel()
				{
					Id = ul.LessonId,
					MapId = ul.Lesson.MapId,
					Title = ul.Lesson.Title,
				}).ToList(),
				CurrentLevel = new LevelViewModel()
				{
					Id = user.Level.Id,
					LevelNumber = user.Level.LevelNumber,
					LevelTitle = user.Level.LevelTitle,
				},
				MapsCoverage = user.UserMaps.ToDictionary(
						um => new MapViewModel()
						{
							Id = um.MapId,
							Description = um.Map.Description,
							MapCategory = um.Map.MapCategory,
							Title = um.Map.Title,
						},
						um => (user.UserLessons.Count(ul => ul.Lesson.MapId == um.MapId)) / ((decimal)um.Map.Lessons.Count()) * 100
					)
			};

			return result;
		}

		public async Task<bool> GrantUserXp(Guid userId, Guid lessonId)
		{
			var lesson = await _lessonRepository.GetAllAttached().FirstOrDefaultAsync(l => l.Id == lessonId);
			var user = await _applicationUserRepository.GetAllAttached()
				.Include(u => u.UserLessons)
				.FirstOrDefaultAsync(u => u.Id == userId);

			if (lesson == null || user == null)
			{
				return false;
			}

			if (!user.UserLessons.Any(ul => ul.LessonId == lessonId))
			{
				user.CurrentXP += lesson.XP;
				return await _applicationUserRepository.UpdateAsync(user);
			}

			return true;
		}

		public async Task<bool> TryLevelUp(Guid userId)
		{
			var user = await _applicationUserRepository.GetAllAttached()
				.Include(p => p.Level)
				.FirstOrDefaultAsync(p => p.Id == userId);
			if (user == null)
			{
				return false;
			}

			var currentLevel = user.Level;
			var nextLevel = await _levelRepository.GetAllAttached()
				.FirstOrDefaultAsync(l => l.LevelNumber == currentLevel.LevelNumber + 1);
			if (nextLevel == null)
			{
				return false;
			}

			if (user.CurrentXP >= nextLevel.RequiredXP)
			{
				user.LevelId = nextLevel.Id;
				user.CurrentXP = user.CurrentXP - nextLevel.RequiredXP;
				await _applicationUserRepository.UpdateAsync(user);
				return true;
			}

			return false;
		}


		public async Task<bool> UpdateMapCoverage(Guid userId, Guid lessonId)
		{
			var user = await _applicationUserRepository.GetAllAttached()
				.Include(u => u.UserMaps)
				.ThenInclude(um => um.Map)
				.ThenInclude(m => m.Lessons)
				.Include(u => u.UserLessons)
				.FirstOrDefaultAsync(u => u.Id == userId);
			if (user == null)
			{
				return false;
			}

			var map = await _mapRepository.GetAllAttached()
				.Include(m => m.Lessons)
				.Where(m => m.Lessons.Any(l => l.Id == lessonId))
				.FirstOrDefaultAsync();
			if (map == null)
			{
				return false;
			}

			var lessonsForCurrentMapPassed = user.UserLessons.Count(ul => ul.Lesson.MapId == map.Id);
			var totalMapLessons = map.Lessons.Count();
			var coveragePercent = (lessonsForCurrentMapPassed / (double)totalMapLessons) * 100;

			var userMap = user.UserMaps.FirstOrDefault(u => u.UserId == userId && u.MapId == map.Id);
			if (userMap == null)
			{
				return false;
			}
			userMap.PercentCovered = coveragePercent;
			return await _applicationUserRepository.UpdateAsync(user);
		}
		public async Task<(bool isSuccessful, IEnumerable<AchievementGrantedViewModel> achievementsGranted)> CheckForAchievementsToGrantAsync(Guid userId)
		{
			var achievementsGranted = new List<AchievementGrantedViewModel>();
			var user = await _applicationUserRepository.GetAllAttached()
				.Include(u => u.UserAchievements)
				.Include(u => u.UserMaps)
				.Include(u => u.Level)
				.Include(u => u.UserLessons)
				.FirstOrDefaultAsync(u => u.Id == userId);
			if (user == null)
			{
				return (false, achievementsGranted);
			}

			var userAchievements = user.UserAchievements.Select(ua => ua.AchievementId);
			var achievementsAvailable = await _achievementRepository.GetAllAttached()
				.Where(a => !userAchievements.Contains(a.Id) && !a.IsDeleted)
				.ToListAsync();

			//Check for achievements that the user is due for:
			CheckMapsCoverageAchievement(user, achievementsGranted, achievementsAvailable);
			CheckLevelsReachedAchievement(user, achievementsGranted, achievementsAvailable);
			CheckLessonsLearnedAchievement(user, achievementsGranted, achievementsAvailable);
			CheckDailyQuestsPassedAchievement(user, achievementsGranted, achievementsAvailable);

			foreach (var ach in achievementsGranted.Select(a => a.Id))
			{
				var achievement = achievementsAvailable.FirstOrDefault(a => a.Id == ach);
				if (achievement == null)
				{
					continue;
				}

				user.UserAchievements.Add(new UserAchievement()
				{
					UserId = user.Id,
					AchievementId = achievement.Id
				});
			}
			await _applicationUserRepository.UpdateAsync(user);

			return (true, achievementsGranted);
		}

		private void CheckMapsCoverageAchievement(ApplicationUser user, List<AchievementGrantedViewModel> achievementsGranted, List<Achievement> achievementsAvailable)
		{
			var availableMapCoverageAchievements = achievementsAvailable
				.Where(ach => ach.ConditionType == ConditionType.MapsCovered)
				.ToList();

			foreach (var ach in availableMapCoverageAchievements)
			{
				switch (ach.ConditionValue)
				{
					case 50: // half a map covered
						if (user.UserMaps.Any(um => um.PercentCovered >= 50))
						{
							achievementsGranted.Add(new AchievementGrantedViewModel()
							{
								Id = ach.Id,
								Title = ach.Title,
								Description = ach.Description,
							});
						}
						break;
					case 100: // one whole map covered
						if (user.UserMaps.Any(um => um.PercentCovered == 100))
						{
							achievementsGranted.Add(new AchievementGrantedViewModel()
							{
								Id = ach.Id,
								Title = ach.Title,
								Description = ach.Description,
							});
						}
						break;
					default:
						if (user.UserMaps.Count(um => um.PercentCovered >= 100) == ach.ConditionValue)
						{
							achievementsGranted.Add(new AchievementGrantedViewModel()
							{
								Id = ach.Id,
								Title = ach.Title,
								Description = ach.Description,
							});
						}
						break;
				}
			}
		}

		private void CheckLevelsReachedAchievement(ApplicationUser user, List<AchievementGrantedViewModel> achievementsGranted, List<Achievement> achievementsAvailable)
		{
			var availableLevelsReachedAchievements = achievementsAvailable
				.Where(ach => ach.ConditionType == ConditionType.LevelsReached)
				.ToList();

			foreach (var ach in availableLevelsReachedAchievements)
			{
				if (ach.ConditionValue <= user.Level.LevelNumber)
				{
					achievementsGranted.Add(new AchievementGrantedViewModel()
					{
						Id = ach.Id,
						Title = ach.Title,
						Description = ach.Description,
					});
				}
			}
		}

		private void CheckLessonsLearnedAchievement(ApplicationUser user, List<AchievementGrantedViewModel> achievementsGranted, List<Achievement> achievementsAvailable)
		{
			var availableLessonsLearnedAchievements = achievementsAvailable
				.Where(ach => ach.ConditionType == ConditionType.LessonsLearned)
				.ToList();

			foreach (var ach in availableLessonsLearnedAchievements)
			{
				if (user.UserLessons.Count() >= ach.ConditionValue)
				{
					achievementsGranted.Add(new AchievementGrantedViewModel()
					{
						Id = ach.Id,
						Title = ach.Title,
						Description = ach.Description,
					});
				}
			}
		}

		private void CheckDailyQuestsPassedAchievement(ApplicationUser user, List<AchievementGrantedViewModel> achievementsGranted, List<Achievement> achievementsAvailable)
		{
			//TODO: Add UserDailyQuests in db when implementing the daily quests
		}

	}
}
