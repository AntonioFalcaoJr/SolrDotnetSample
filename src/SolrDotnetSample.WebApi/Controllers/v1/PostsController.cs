using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services;
using SolrDotnetSample.WebApi.Abstractions;
using SolrDotnetSample.WebApi.Dtos;

namespace SolrDotnetSample.WebApi.Controllers.v1
{
    [ApiVersion("1")]
    public class PostsController : SolrDotnetSampleControllerBase<Post, PostDto, Guid>
    {
        public PostsController(IPostRelationalService service, IMapper mapper)
            : base(service, mapper) { }
    }
}