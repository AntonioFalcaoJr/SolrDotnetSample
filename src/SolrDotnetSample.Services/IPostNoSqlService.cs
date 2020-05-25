using System;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services.Abstractions.NoSql;

namespace SolrDotnetSample.Services
{
    public interface IPostNoSqlService : INoSqlService<Post, Guid> { }
}