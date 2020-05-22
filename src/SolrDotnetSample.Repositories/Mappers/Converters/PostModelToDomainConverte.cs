using AutoMapper;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories.Mappers.Converters
{
    public class PostModelToDomainConverte : ITypeConverter<PostModel, Post>
    {
        public Post Convert(PostModel source, Post destination, ResolutionContext context)
            => new Post(source.Id, source.Description, source.Title, source.Price, source.ExpiryDate,
                source.PostDate, source.IsActive, source.IsSold);
    }
}