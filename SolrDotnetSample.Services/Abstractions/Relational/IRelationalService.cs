using SolrDotnetSample.Domain.Abstractions;

namespace SolrDotnetSample.Services.Abstractions.Relational
{
    public interface IRelationalService<TEntity, in TId> : IService<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct { }
}