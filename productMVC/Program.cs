using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using productMVC.Data;
namespace productMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<productMVCContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("productMVCContext") ?? throw new InvalidOperationException("Connection string 'productMVCContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

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
            app.MapDefaultControllerRoute();

            app.UseAuthorization();
           // app.UseMvc();

           /* app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");*/

            app.Run();
        }
    }
}
