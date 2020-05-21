using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolrDotnetSample.Repositories.IoC;
using SolrDotnetSample.Services.IoC;

namespace SolrDotnetSample.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRepositories();
            services.AddAutoMapper();
            services.AddServices();

            services.AddSolr(options =>
            {
                options.BaseAddress = Configuration["Solr:BaseAddress"];
                options.Core = Configuration["Solr:Core"];
            });
        }
    }
}