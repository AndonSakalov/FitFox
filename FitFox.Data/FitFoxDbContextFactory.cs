using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FitFox.Data
{
	public class FitFoxDbContextFactory : IDesignTimeDbContextFactory<FitFoxDbContext>
	{
		public FitFoxDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<FitFoxDbContext>();
			optionsBuilder.UseSqlServer(
				"Server=DESKTOP-SEO0PUN\\SQLEXPRESS;Database=FitFoxDB;Trusted_Connection=True;TrustServerCertificate=True;");

			return new FitFoxDbContext(optionsBuilder.Options);
		}
	}
}
