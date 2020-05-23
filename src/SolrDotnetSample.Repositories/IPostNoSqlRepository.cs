using System;
using SolrDotnetSample.Repositories.Abstractions.NoSql;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories
{
    public interface IPostNoSqlRepository : INoSqlRepository<PostModel, Guid> { }
}