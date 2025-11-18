using FitFox.Data;
using FitFox.Data.Models;
using FitFox.Services.Data;
using FitFox.Web.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace FitFox
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

			builder.Services.AddDbContext<FitFoxDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

			//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<FitFoxDbContext>();

			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			builder.Services
				.AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
			{
				options.SignIn.RequireConfirmedAccount = false;
				options.SignIn.RequireConfirmedPhoneNumber = false;
				options.SignIn.RequireConfirmedEmail = false;
				options.User.RequireUniqueEmail = true;
			})
				.AddEntityFrameworkStores<FitFoxDbContext>()
				.AddRoles<IdentityRole<Guid>>()
				.AddSignInManager<SignInManager<ApplicationUser>>()
				.AddUserManager<UserManager<ApplicationUser>>()
				.AddDefaultTokenProviders();


			builder.Services.RegisterRepositories(typeof(ApplicationUser).Assembly);
			builder.Services.RegisterServices(typeof(MapService).Assembly);

			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();

			builder.Services.ConfigureApplicationCookie(options =>
			{
				options.LoginPath = "/Identity/Account/Login";
			});

			builder.Services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(30); // how long to keep session alive
				options.Cookie.HttpOnly = true;
				options.Cookie.IsEssential = true;
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseStaticFiles();

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseSession();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");
			app.MapRazorPages();

			app.Run();
		}
	}
}
