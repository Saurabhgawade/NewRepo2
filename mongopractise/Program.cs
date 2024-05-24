using MongoDB.Driver;
using mongopractise.Models;

namespace mongopractise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.Configure<Mongo>(builder.Configuration.GetSection(nameof(Mongo)));
            builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("Connection:Database")));
            builder.Services.AddTransient<InterfaceMongo, ServiceMango>();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "test",
                    Version = "v2"
                });
            });

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("swagger/v2/swagger.json", "test");
            });


            app.MapControllers();

            app.Run();
        }
    }
}
