using AutoMapper;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services.Dtos;

namespace SolrDotnetSample.Services.Mappers
{
    public class DtoToDomainProfile : Profile
    {
        public DtoToDomainProfile()
        {
            CreateMap<PostDto, Post>().ReverseMap();
        }
    }
}