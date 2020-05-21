using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SolrDotnetSample.Repositories.Mappers;
using SolrDotnetSample.Services.Mappers;

namespace SolrDotnetSample.Services.IoC
{
    public static class IoCServices
    {
        public static IServiceCollection AddServiceAutoMapper(this IServiceCollection services)
            => services.AddAutoMapper(typeof(DtoToDomainProfile), typeof(ModelToDomainProfile), typeof(DomainToModelProfile));

        public static IServiceCollection AddServices(this IServiceCollection services)
            => services.AddScoped<IPostService, PostService>();
    }
}