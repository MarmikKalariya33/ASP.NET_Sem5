using Microsoft.EntityFrameworkCore;
using api_learn.Models;
using System.Runtime.CompilerServices;
namespace api_learn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(Options =>
            Options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

            // two lines code connection to data base 
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            // Add services
            builder.Services.AddControllers();

            // Swagger services
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure Swagger
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}