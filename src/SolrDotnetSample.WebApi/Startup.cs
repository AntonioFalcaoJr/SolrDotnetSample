using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolrDotnetSample.Repositories.IoC;
using SolrDotnetSample.Repositories.Mappers;
using SolrDotnetSample.Services.IoC;
using SolrDotnetSample.WebApi.Mappers;

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
            app.UseApiVersioning();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddApiVersioning();
            services.AddRepositories();
            services.AddServices();
            services.AddAutoMapper(typeof(DtoToDomainProfile), typeof(ModelToDomainProfile), typeof(DomainToModelProfile));
            services.AddSolr(options =>
            {
                options.BaseAddress = Configuration["Solr:BaseAddress"];
                options.Core = Configuration["Solr:Core"];
            });
        }
    }
}