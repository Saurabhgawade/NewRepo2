﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using entitycodefirstfinal.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Connections.Features;
using StackExchange.Redis;
namespace entitycodefirstfinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<entitycodefirstfinalContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("entitycodefirstfinalContext") ?? throw new InvalidOperationException("Connection string 'entitycodefirstfinalContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<entitycodefirstfinalContext>().AddDefaultTokenProviders();
           
            builder.Services.AddSingleton<IConnectionMultiplexer>(x => ConnectionMultiplexer.Connect(builder.Configuration.GetSection("Redis:Connection").Value!.ToString()));
            builder.Services.AddTransient<RedisInterface, RedisService>();
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
