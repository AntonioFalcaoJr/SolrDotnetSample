using AutoMapper;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Repositories.Mappers.Converters;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories.Mappers
{
    public class ModelToDomainProfile : Profile
    {
        public ModelToDomainProfile()
        {
            CreateMap<PostModel, Post>()
               .ConvertUsing<PostModelToDomainConverte>();
        }
    }
}