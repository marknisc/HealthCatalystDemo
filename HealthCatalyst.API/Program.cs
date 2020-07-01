
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HealthCatalyst.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureLogging(ctx =>
                    {
                        ctx.ClearProviders();
                        ctx.AddDebug();
                        ctx.AddConsole();
                    });
                    webBuilder.UseUrls("http://localhost:5200");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
