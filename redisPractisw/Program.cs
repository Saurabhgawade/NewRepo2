using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using redisPractisw.Data;
using redisPractisw.Interface;
using redisPractisw.Service;
using StackExchange.Redis;
namespace redisPractisw
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<redisPractiswContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("redisPractiswContext") ?? throw new InvalidOperationException("Connection string 'redisPractiswContext' not found.")));

            // Add services to the container.
            builder.Services.AddSingleton<IConnectionMultiplexer>(options => ConnectionMultiplexer.Connect(builder.Configuration.GetSection("Connection:redis").Value!.ToString()));
            builder.Services.AddTransient<IRedisCache, RedisService>();
            builder.Services.AddControllersWithViews();

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
