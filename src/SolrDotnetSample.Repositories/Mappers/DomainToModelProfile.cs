using AutoMapper;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories.Mappers
{
    public class DomainToModelProfile : Profile
    {
        public DomainToModelProfile()
        {
            CreateMap<Post, PostModel>();
        }
    }
}