using FitFox.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FitFox.Data
{
	public class FitFoxDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{
		public FitFoxDbContext()
		{

		}

		public FitFoxDbContext(DbContextOptions<FitFoxDbContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		public virtual DbSet<Achievement> Achievements { get; set; }
		public virtual DbSet<Lesson> Lessons { get; set; }
	}
}

