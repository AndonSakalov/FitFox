using FitFox.Web.ViewModels.Achievement;
using FitFox.Web.ViewModels.Lesson;
using FitFox.Web.ViewModels.Level;
using FitFox.Web.ViewModels.Map;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Web.ViewModels.Player
{
	public class PlayerInfo
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		public ICollection<LessonDisplayViewModel> CompletedLessons { get; set; } = new HashSet<LessonDisplayViewModel>();

		[Required]
		public LevelViewModel CurrentLevel { get; set; } = null!;

		[Required]
		public int CurrentXP { get; set; }

		[Required]
		public IDictionary<MapViewModel, decimal> MapsCoverage { get; set; } = new Dictionary<MapViewModel, decimal>();

		[Required]
		public ICollection<AchievementViewModel> Achievements { get; set; } = new HashSet<AchievementViewModel>();
	}
}
