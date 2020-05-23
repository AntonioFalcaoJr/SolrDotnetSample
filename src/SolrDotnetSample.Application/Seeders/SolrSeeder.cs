using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Repositories;
using SolrDotnetSample.Services;

namespace SolrDotnetSample.Application.Seeders
{
    public class SolrSeeder : ISolrSeeder
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly SeedOptions _options;
        private readonly IPostRelationalRepository _postRelationalRepository;
        private readonly IPostService _postService;

        public SolrSeeder(IPostService postService, IConfiguration configuration, IPostRelationalRepository postRelationalRepository, IMapper mapper)
        {
            _postService = postService;
            _configuration = configuration;
            _postRelationalRepository = postRelationalRepository;
            _mapper = mapper;
            _options = new SeedOptions();
        }

        public async Task SeedAsync(CancellationToken cancellationToken)
        {
            while (true)
            {
                var options = GetSeedOptions();

                switch (_options.Source)
                {
                    case Source.New:
                    {
                        var posts = new List<Post>();
                        for (var i = 0; i < options.Amount; i++)
                            posts.Add(new Post(Guid.NewGuid(), "Description", "Title", 0.0, DateTime.Now, DateTime.Now, true, true));

                        await IndexAsync(posts, cancellationToken);
                        break;
                    }

                    case Source.Relational:
                    {
                        var posts = _postRelationalRepository.SelectAllAsync(model => model.Id != null, cancellationToken);
                        await IndexAsync(_mapper.Map<IEnumerable<Post>>(posts), cancellationToken);
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Opção não disponível");
                        continue;
                    }
                }

                break;
            }
        }

        private SeedOptions GetSeedOptions()
        {
            Console.WriteLine("Define amount data for generate:");
            var input = Console.ReadLine();
            _options.Amount = int.TryParse(input, out var amount) ? amount : default;

            Console.WriteLine("Define source data:");
            Console.WriteLine("Use [1] for New data generation or [2] for seeding from relational database:");
            input = Console.ReadLine();
            _options.Source = Enum.TryParse<Source>(input, out var source) ? source : default;

            return _options;
        }

        private async Task IndexAsync(IEnumerable<Post> posts, CancellationToken cancellationToken)
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
                await SeedAsync(cancellationToken);
            }
            catch (HttpRequestException e)
                when ((e.InnerException as SocketException)?.SocketErrorCode is SocketError.ConnectionRefused)
            {
                Console.WriteLine("Serviço do Solr não está disponível");
                await SeedAsync(cancellationToken);
            }
        }
    }

    internal class SeedOptions
    {
        public int Amount { get; set; }
        public Source Source { get; set; }
    }

    internal enum Source
    {
        New = 1,
        Relational = 2
    }
}