using System;
using AutoMapper;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Repositories;
using SolrDotnetSample.Repositories.Models;
using SolrDotnetSample.Services.Abstractions;

namespace SolrDotnetSample.Services
{
    public class PostRelationalService : Service<Post, PostModel, Guid>, IPostRelationalService
    {
        public PostRelationalService(IPostRelationalRepository repository, IMapper mapper)
            : base(repository, mapper) { }
    }
}