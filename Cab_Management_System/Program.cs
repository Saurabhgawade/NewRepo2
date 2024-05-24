using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cab_Management_System.Data;
using Microsoft.AspNetCore.Identity;
namespace Cab_Management_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Cab_Management_SystemContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Cab_Management_SystemContext") ?? throw new InvalidOperationException("Connection string 'Cab_Management_SystemContext' not found.")));

            // Add services to the container.
            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<Cab_Management_SystemContext>().AddDefaultTokenProviders();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddControllersWithViews();
            builder.Services.AddMvc(options => options.EnableEndpointRouting=false);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseMvc();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
