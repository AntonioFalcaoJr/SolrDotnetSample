using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using SolrDotnetSample.Repositories.Models;
using SolrDotnetSample.Services;

namespace SolrDotnetSample.Application
{
    public class HostedService : IHostedService
    {
        private readonly IPostService _postService;

        public HostedService(IPostService postService)
        {
            _postService = postService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("UUUUUUUUUUUUUPPPPP");

            await _postService.SaveAsync(new SolrPostModel
            {
                Description = "kkkkk",
                Id = Guid.NewGuid(),
                IsActive = true,
                Price = 0.0,
                Title = "Pega essa"
            }, cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("DOOOOOOOWWWNNNNN");

            return Task.FromResult(cancellationToken);
        }
    }
}