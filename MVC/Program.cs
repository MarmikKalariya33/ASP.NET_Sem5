using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });

            app.Run();
        }
    }
}