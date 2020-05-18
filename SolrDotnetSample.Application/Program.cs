using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SolrDotnetSample.Application
{
    internal class Program
    {
        private static IServiceCollection _serviceCollection;
        private static IServiceProvider _serviceProvider;
        private static Startup _startup;
        
        public Program()
        {
            _serviceCollection = new ServiceCollection();
            _startup = new Startup();
        }

        public static void Main(string[] args)
        {
            _startup.ConfigureServices(_serviceCollection);
            _serviceProvider = _serviceCollection.BuildServiceProvider();

            _serviceProvider
               .GetService<ILoggerFactory>().CreateLogger<Program>();
               //.AddConsole(LogLevel.Debug);

            var logger = _serviceProvider.GetService<ILoggerFactory>()
               .CreateLogger<Program>();

            logger.LogDebug("Logger is working!");

            var service = _serviceProvider.GetService<IApp>();
            service.Run();
        }
    }
}