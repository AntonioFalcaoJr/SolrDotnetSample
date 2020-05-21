using Microsoft.Extensions.DependencyInjection;

namespace SolrDotnetSample.Services.IoC
{
    public static class IoCServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
            => services.AddScoped<IPostService, PostService>();
    }
}