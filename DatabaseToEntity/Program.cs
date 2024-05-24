using DatabaseToEntity.Models;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DatabaseToEntity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DatabaseToEntityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
            builder.Services.AddControllersWithViews();
            builder.Services.AddHealthChecks().AddSqlServer(builder.Configuration.GetConnectionString("Connection"),name:"sql health check",failureStatus:HealthStatus.Unhealthy)
                .AddCheck("api check",()=>HealthCheckResult.Healthy("api healthy"));

            builder.Services.AddHealthChecksUI(options =>
            {
                options.AddHealthCheckEndpoint("health check option", "/healthcheck");
            }).AddInMemoryStorage();
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

            app.UseAuthorization();
           // app.MapHealthChecks("/health", new HealthCheckOptions { ResponseWriter = UIResponseWriter });
            app.MapHealthChecksUI(options => options.UIPath = "/dashboard");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
