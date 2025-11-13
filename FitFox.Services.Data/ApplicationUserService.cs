using FitFox.Data.Models;
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

		public ApplicationUserService(
			IRepository<ApplicationUser, Guid> applicationUserRepository,
			IRepository<Map, Guid> mapRepository,
			IRepository<Lesson, Guid> lessonRepository)
		{
			_applicationUserRepository = applicationUserRepository;
			_mapRepository = mapRepository;
			_lessonRepository = lessonRepository;
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

			bool alreadyStarted = user.UserLessons.Any(u => u.LessonId == lessonId);

			if (!alreadyStarted)
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
						um => (user.UserLessons.Where(ul => ul.Lesson.MapId == um.MapId).Count()) / ((decimal)um.Map.Lessons.Count()) * 100
					)
			};

			return result;
		}

		public async Task<bool> GrantUserXp(Guid userId, Guid lessonId)
		{
			var lesson = await _lessonRepository.GetAllAttached().FirstOrDefaultAsync(l => l.Id == lessonId);
			var user = await _applicationUserRepository.GetAllAttached().FirstOrDefaultAsync(u => u.Id == userId);

			if (lesson == null || user == null)
			{
				return false;
			}

			var lessonXP = lesson.XP;
			user.CurrentXP += lessonXP;
			bool result = await _applicationUserRepository.UpdateAsync(user);

			return result;
		}
	}
}
