using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using SolrDotnetSample.Domain.Entities;
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
            var posts = new List<Post>();
            var amount = GetAmountRequested();

            for (var i = 0; i < amount; i++) posts.Add(new Post(Guid.NewGuid(), "Description", "Title", 0.0, DateTime.Now, DateTime.Now, true, true));

            await _postService.SaveManyAsync(posts, cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.FromResult(cancellationToken);

        private static int GetAmountRequested()
        {
            Console.WriteLine("Define amount for generate:");
            var input = Console.ReadLine();
            return int.TryParse(input, out var amount) ? amount : default;
        }
    }
}