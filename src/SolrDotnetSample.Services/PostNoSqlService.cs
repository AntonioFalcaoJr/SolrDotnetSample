using System;
using AutoMapper;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Repositories;
using SolrDotnetSample.Repositories.Models;
using SolrDotnetSample.Services.Abstractions;

namespace SolrDotnetSample.Services
{
    public class PostNoSqlService : Service<Post, PostModel, Guid>, IPostNoSqlService
    {
        public PostNoSqlService(IPostNoSqlRepository repository, IMapper mapper)
            : base(repository, mapper) { }
    }
}