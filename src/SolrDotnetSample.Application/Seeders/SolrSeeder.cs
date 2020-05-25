using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SolrDotnetSample.Repositories;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Application.Seeders
{
    public class SolrSeeder : ISolrSeeder
    {
        private readonly IConfiguration _configuration;
        private readonly SeedOptions _options;
        private readonly IPostNoSqlRepository _postNoSqlRepository;
        private readonly IPostRelationalRepository _postRelationalRepository;
        private readonly ILogger<SolrSeeder> _logger;

        public SolrSeeder(IConfiguration configuration, IPostRelationalRepository postRelationalRepository, IPostNoSqlRepository postNoSqlRepository,
            ILogger<SolrSeeder> logger)
        {
            _postRelationalRepository = postRelationalRepository;
            _postNoSqlRepository = postNoSqlRepository;
            _configuration = configuration;
            _logger = logger;
            _options = new SeedOptions();
        }

        public async Task SeedAsync(CancellationToken cancellationToken)
        {
            var options = GetSeedOptions();

            switch (_options.Source)
            {
                case Source.New:
                {
                    var posts = GeneratePostModels(options.Amount);
                    await IndexAsync(posts, cancellationToken);
                    break;
                }

                case Source.Relational:
                {
                    var posts = await _postRelationalRepository.SelectAllAsync(model => model.Id != null, cancellationToken);
                    await IndexAsync(posts, cancellationToken);
                    break;
                }

                default:
                {
                    _logger.LogError("INVALID OPTION");
                    await SeedAsync(cancellationToken);
                    break;
                }
            }

            _logger.LogInformation("DATA SEEDED WITH SUCCESS!");
            Environment.Exit(Environment.ExitCode);
        }

        private static IEnumerable<PostModel> GeneratePostModels(int amount)
        {
            var posts = new List<PostModel>();
            for (var i = 0; i < amount; i++)
                posts.Add(new PostModel
                {
                    Id = Guid.NewGuid(),
                    Description = "Description",
                    Title = "Title",
                    Price = 0.0,
                    ExpiryDate = DateTime.Now,
                    PostDate = DateTime.Now,
                    IsActive = true,
                    IsSold = true
                });
            return posts;
        }

        private SeedOptions GetSeedOptions()
        {
            Console.WriteLine("DEFINE AMOUNT DATA FOR SEEDING:");
            var input = Console.ReadLine();
            _options.Amount = int.TryParse(input, out var amount) ? amount : default;

            Console.WriteLine("DEFINE SOURCE DATA:");
            Console.WriteLine("USE [1] FOR NEW DATA GENERETION OR [2] FOR SEEDING FROM RELATIONAL DATABASE:");
            input = Console.ReadLine();
            _options.Source = Enum.TryParse<Source>(input, out var source) ? source : default;

            return _options;
        }

        private async Task IndexAsync(IEnumerable<PostModel> posts, CancellationToken cancellationToken)
        {
            try
            {
                await _postNoSqlRepository.InsertManyAsync(posts, cancellationToken);
            }
            catch (HttpRequestException e) when ((e.InnerException as SocketException)?.SocketErrorCode is SocketError.AddressNotAvailable)
            {
                _logger.LogError("SOLR ADDRESS ENTERED IN APPSETTINGS CANNOT BE FOUND.");
                _logger.LogInformation($"CURRENT ADDRESS: {_configuration["Solr:BaseAddress"] + "/" + _configuration["Solr:Core"]}");
                await SeedAsync(cancellationToken);
            }
            catch (HttpRequestException e) when ((e.InnerException as SocketException)?.SocketErrorCode is SocketError.ConnectionRefused)
            {
                _logger.LogError("SOLR SERVICE IS NOT AVAILABLE.");
                await SeedAsync(cancellationToken);
            }
        }
    }
}