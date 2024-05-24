using Microsoft.OpenApi.Models;

namespace MvcTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers();
            builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

             builder.Services.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("v2", new OpenApiInfo
                 {
                     Title = "MVCCallWebAPI",
                     Version = "v2"
                 });
             });
            builder.Services.AddControllers();

          

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
            app.UseSwagger();
            app.UseSwaggerUI();
             app.UseSwagger();

             app.UseSwaggerUI(c =>
             {
                 c.SwaggerEndpoint("/swagger/v2/swagger.json", "MVCCallWebAPI");
             });

            app.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
            app.UseMvc();

            app.Run();
        }
    }
}
