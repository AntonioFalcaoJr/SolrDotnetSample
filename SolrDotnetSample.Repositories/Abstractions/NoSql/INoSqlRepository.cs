using SolrDotnetSample.Domain.Abstractions;

namespace SolrDotnetSample.Repositories.Abstractions.NoSql
{
    public interface INoSqlRepository<TEntity, in TId> : IRepository<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct { }
}