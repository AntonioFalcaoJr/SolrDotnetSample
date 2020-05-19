using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SolrDotnetSample.Repositories.IoC;
using SolrDotnetSample.Services.IoC;

namespace SolrDotnetSample.Application
{
    internal class Program
    {
        public static async Task Main(string[] args)
            => await new HostBuilder()
               .ConfigureHostConfiguration(configHost =>
                {
                    configHost.SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json", true, true)
                       .AddEnvironmentVariables()
                       .AddCommandLine(args);
                })
               .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp.SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json", true, true)
                       .AddJsonFile($"appsettings.{hostContext.HostingEnvironment.EnvironmentName}.json", true, true)
                       .AddEnvironmentVariables()
                       .AddCommandLine(args);
                })
               .ConfigureServices((hostContext, services) =>
                {
                    services.AddLogging()
                       .AddRepository()
                       .AddAutoMapper()
                       .AddSolr()
                       .AddServices()
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