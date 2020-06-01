using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using SolrDotnetSample.Application.Seeders;

namespace SolrDotnetSample.Application
{
    public class HostedService : IHostedService
    {
        private readonly ISolrSeeder _seeder;

        public HostedService(ISolrSeeder seeder)
        {
            _seeder = seeder;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
            => await _seeder.SeedAsync(cancellationToken);

        public async Task StopAsync(CancellationToken cancellationToken)
            => await Task.FromResult<>(Environment.Exit(Environment.ExitCode));
    }
}