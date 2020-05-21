using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SolrDotnetSample.Repositories.Mappers;
using SolrNet;

namespace SolrDotnetSample.Repositories.IoC
{
    public static class IoCRepositories
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
            => services.AddScoped<IPostRepository, PostRepository>();

        public static IServiceCollection AddRepositoryAutoMapper(this IServiceCollection services)
            => services.AddAutoMapper(typeof(ModelToDomainProfile), typeof(DomainToModelProfile));

        public static IServiceCollection AddSolr(this IServiceCollection services)
            => services.AddSolrNet("http://localhost:8983/solr/my_core");
    }
}