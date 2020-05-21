using System;
using AutoMapper;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Repositories;
using SolrDotnetSample.Repositories.Models;
using SolrDotnetSample.Services.Abstractions;

namespace SolrDotnetSample.Services
{
    public class PostService : Service<Post, PostModel, Guid>, IPostService
    {
        public PostService(IPostRepository repository, IMapper mapper)
            : base(repository, mapper) { }
    }
}