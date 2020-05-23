using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services;

namespace SolrDotnetSample.Application.Seeders
{
    public class SolrSeeder : ISolrSeeder
    {
        private readonly IPostService _postService;
        private readonly IConfiguration _configuration;

        public SolrSeeder(IPostService postService, IConfiguration configuration)
        {
            _postService = postService;
            _configuration = configuration;
        }

        public async Task Seed(CancellationToken cancellationToken)
        {
            var posts = new List<Post>();
            var amount = GetAmountRequested();

            for (var i = 0; i < amount; i++) posts.Add(new Post(Guid.NewGuid(), "Description", "Title", 0.0, DateTime.Now, DateTime.Now, true, true));

            await IndexAsync(cancellationToken, posts);
        }

        private async Task IndexAsync(CancellationToken cancellationToken, IEnumerable<Post> posts)
        {
            try
            {
                await _postService.SaveManyAsync(posts, cancellationToken);
            }
            catch (HttpRequestException e)
                when ((e.InnerException as SocketException)?.SocketErrorCode is SocketError.AddressNotAvailable)
            {
                Console.WriteLine("Endereço do Solr informado no appsettings não pode ser encontrado.");
                Console.WriteLine($"Endereço atual: {_configuration["Solr:BaseAddress"] + "/" + _configuration["Solr:Core"]}");
                await Seed(cancellationToken);
            }
            catch (HttpRequestException e)
                when ((e.InnerException as SocketException)?.SocketErrorCode is SocketError.ConnectionRefused)
            {
                Console.WriteLine("Serviço do Solr não está disponível");
                await Seed(cancellationToken);
            }
        }

        private static int GetAmountRequested()
        {
            Console.WriteLine("Define amount for generate:");
            var input = Console.ReadLine();
            return int.TryParse(input, out var amount) ? amount : default;
        }
    }
}