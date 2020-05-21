using System;
using SolrDotnetSample.Repositories.Abstractions.NoSql;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories
{
    public interface IPostRepository : INoSqlRepository<PostModel, Guid> { }
}