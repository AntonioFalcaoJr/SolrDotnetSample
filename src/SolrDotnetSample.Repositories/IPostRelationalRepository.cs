using System;
using SolrDotnetSample.Repositories.Abstractions.Relational;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories
{
    public interface IPostRelationalRepository : IRelationalRepository<PostModel, Guid> { }
}