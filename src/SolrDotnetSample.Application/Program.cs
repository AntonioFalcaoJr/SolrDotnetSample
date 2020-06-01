using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SolrDotnetSample.Application.Seeders;
using SolrDotnetSample.Repositories.IoC;

namespace SolrDotnetSample.Application
{
    internal class Program
    {
        private const string SettingsName = "appsettings";
        private const string SettingsExtention = ".json";
        private const string AppSettings = SettingsName + SettingsExtention;

        public static async Task Main(string[] args)
            => await new HostBuilder()
               .ConfigureHostConfiguration(configHost =>
                {
                    configHost
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile(AppSettings, true, true)
                       .AddEnvironmentVariables()
                       .AddCommandLine(args);
                })
               .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile(AppSettings, true, true)
                       .AddJsonFile(SettingsName + "." + hostContext.HostingEnvironment.EnvironmentName + SettingsExtention, true, true)
                       .AddEnvironmentVariables()
                       .AddCommandLine(args);
                })
               .ConfigureServices((hostContext, services) =>
                {
                    services
                       .AddLogging()
                       .AddRepositories()
                       .AddDbContext(options => options.ConnectionString = hostContext.Configuration.GetConnectionString("DefaultConnection"))
                       .AddSolr(options =>
                        {
                            options.BaseAddress = hostContext.Configuration["Solr:BaseAddress"];
                            options.Core = hostContext.Configuration["Solr:Core"];
                        })
                       .AddScoped<ISolrSeeder, SolrSeeder>()
                       .AddHostedService<HostedService>();
                })
               .ConfigureLogging((hostContext, configLogging) =>
                {
                    configLogging.AddConsole();
                })
               .UseConsoleLifetime()
               .Build()
               .RunAsync();
    }
}