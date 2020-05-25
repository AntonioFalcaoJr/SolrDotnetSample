using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services;
using SolrDotnetSample.WebApi.Abstractions;
using SolrDotnetSample.WebApi.Dtos;

namespace SolrDotnetSample.WebApi.Controllers.v2
{
    [ApiVersion("2")]
    public class PostsController : SolrDotnetSampleControllerBase<Post, PostDto, Guid>
    {
        public PostsController(IPostNoSqlService service, IMapper mapper)
            : base(service, mapper) { }
    }
}