using System;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services.Abstractions;

namespace SolrDotnetSample.Services
{
    public interface IPostRelationalService : IService<Post, Guid> { }
}