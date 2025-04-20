
using dotnet_api.DataAcces;
using dotnet_api.Logic;
using dotnet_api.Middleware;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace dotnet_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<HockeyPlayerContext>(o=>o.UseAzureSql(builder.Configuration.GetConnectionString("DBConnection")));
            builder.Services.AddControllers();

            builder.Services.AddScoped<IPlayerService, PlayerService>();
            builder.Services.AddAutoMapper(typeof(Program));

            var app = builder.Build();

            app.UseMiddleware<BasicAuthHandler>();

            app.MapControllers();

            app.Run();
        }
    }
}
