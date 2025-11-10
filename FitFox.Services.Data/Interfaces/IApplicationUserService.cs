namespace FitFox.Services.Data.Interfaces
{
	public interface IApplicationUserService
	{
		Task StartMapForUserAsync(Guid mapId, Guid userId);

		Task StartLessonForUserAsync(Guid lessonId, Guid userId);

		Task<>
	}
}
