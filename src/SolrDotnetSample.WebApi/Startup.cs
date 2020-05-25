using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolrDotnetSample.CrossCuting;
using SolrDotnetSample.Repositories.Contexts;
using SolrDotnetSample.Repositories.IoC;
using SolrDotnetSample.Repositories.Mappers;
using SolrDotnetSample.Services.IoC;
using SolrDotnetSample.WebApi.Mappers;

namespace SolrDotnetSample.WebApi
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Environment = environment;
            Configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, SolrDotnetSampleContext context)
        {
            if (Environment.IsDevelopment()) app.UseDeveloperExceptionPage();
            app.UseApiVersioning();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
            context.Database.Migrate();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddApiVersioning();
            services.AddRepositories();
            services.AddServices();
            services.AddAutoMapper(typeof(DtoToDomainProfile), typeof(ModelToDomainProfile), typeof(DomainToModelProfile));

            services.AddMvcCore(options =>
            {
                options.SuppressAsyncSuffixInActionNames = false;
            });

            services.AddDbContext(options =>
            {
                options.ConnectionString = @$"Data Source={Path.Combine(ProjectProvider.TryGetSolutionDirectoryInfo().FullName,
                    Configuration.GetConnectionString("DefaultConnection"))}";
            });

            services.AddSolr(options =>
            {
                options.BaseAddress = Configuration["Solr:BaseAddress"];
                options.Core = Configuration["Solr:Core"];
            });
        }
    }
}