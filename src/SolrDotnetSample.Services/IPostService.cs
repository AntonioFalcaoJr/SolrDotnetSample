using System;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services.Abstractions.NoSql;

namespace SolrDotnetSample.Services
{
    public interface IPostService : INoSqlService<Post, Guid> { }
}