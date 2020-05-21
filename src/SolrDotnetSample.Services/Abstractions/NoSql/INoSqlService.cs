using SolrDotnetSample.Domain.Abstractions;

namespace SolrDotnetSample.Services.Abstractions.NoSql
{
    public interface INoSqlService<TEntity, in TId> : IService<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct { }
}