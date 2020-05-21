using System;
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
            var post = new Post(Guid.NewGuid(), "Description", "Title", 0.0, DateTime.Now, DateTime.Now, true, true);
            await _postService.SaveAsync(post, cancellationToken);

            var postByDb = await _postService.GetByIdAsync(post.Id, cancellationToken);
            Console.WriteLine(postByDb?.Description ?? "Erro");
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.FromResult(cancellationToken);
    }
}