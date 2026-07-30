using Ecommerse.Model;
using Ecommerse.Services;
using Ecommerse.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
namespace Ecommerse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // builder is a object 
            // services is collection  
            // appdbcontect without this line not allow connect database 
            // options is labda expression 
            builder.Services.AddDbContext<AddDbContext>(Options =>
            Options.UseSqlServer(builder.Configuration.GetConnectionString("default")));
            // usesqlserver use microsoft sql server database
            // builder configration is accesses aplication configration
            // getconnectionstring is get connection string from appsettings.json file

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            builder.Services.AddScoped<Iuserservices,userservices>();

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