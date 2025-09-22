using FitFox.Data.Models;
using FitFox.Data.Models.MappingModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FitFox.Data
{
	public class FitFoxDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{

		public FitFoxDbContext(DbContextOptions<FitFoxDbContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		//Base tables:
		public virtual DbSet<Achievement> Achievements { get; set; }
		public virtual DbSet<Answer> Answers { get; set; }
		public virtual DbSet<Lesson> Lessons { get; set; }
		public virtual DbSet<Level> Levels { get; set; }
		public virtual DbSet<Map> Maps { get; set; }
		public virtual DbSet<Question> Questions { get; set; }


		//Mapping tables:
		public virtual DbSet<UserAchievement> UsersAchievements { get; set; }
		public virtual DbSet<UserLesson> UsersLessons { get; set; }
		public virtual DbSet<UserMap> UsersMaps { get; set; }
	}
}

