using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SolrDotnetSample.Repositories.Mappers;
using SolrNet;

namespace SolrDotnetSample.Repositories.IoC
{
    public static class IoCRepositories
    {
        private static readonly SolrOptions SolrOptions = new SolrOptions();

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
            => services.AddAutoMapper(typeof(ModelToDomainProfile), typeof(DomainToModelProfile));

        public static IServiceCollection AddRepositories(this IServiceCollection services)
            => services.AddScoped<IPostRepository, PostRepository>();

        public static IServiceCollection AddSolr(this IServiceCollection services, Action<SolrOptions> options)
        {
            options.Invoke(SolrOptions);
            return services.AddSolrNet(SolrOptions.Url);
        }
    }

    public class SolrOptions
    {
        public string BaseAddress { get; set; }
        public string Core { get; set; }
        public string Url => BaseAddress + Core;
    }
}