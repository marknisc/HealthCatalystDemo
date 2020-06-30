
using HealthCatalyst.Interfaces.Repository;
using HealthCatalyst.Interfaces.Services;
using HealthCatalyst.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HealthCatalyst.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSingleton(typeof(ILogger<Startup>), typeof(Logger<Startup>));
            services.AddSingleton<IReadRepository>((c) =>
            {
                var logger = c.GetRequiredService<ILogger<ReadRepository>>();
                return new ReadRepository(logger);
            });
            services.AddSingleton<ISearchService>((c) =>
            {
                var logger = c.GetRequiredService<ILogger<SearchService>>();
                var repo = c.GetRequiredService<IReadRepository>();
                return new SearchService(repo, logger);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
