using DemoEntity.Interface;
using DemoEntity.Models;
using DemoEntity.Service;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

namespace DemoEntity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSingleton<IConnectionMultiplexer>(x => ConnectionMultiplexer.Connect(builder.Configuration.GetSection("RedisConnection:Connection").Value!.ToString()));
            builder.Services.AddTransient<IRedisCache, RedisCache>();

            builder.Services.AddDbContext<DemoEntityContext>(
                x => x.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddEndpointsApiExplorer();

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

            /*app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");*/
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
