using AutoMapper;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.WebApi.Dtos;

namespace SolrDotnetSample.WebApi.Mappers
{
    public class DtoToDomainProfile : Profile
    {
        public DtoToDomainProfile()
        {
            CreateMap<PostDto, Post>().ReverseMap();
        }
    }
}