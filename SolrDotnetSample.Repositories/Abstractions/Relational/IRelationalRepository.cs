using poc_console_solr.Domain.Abstractions;

namespace SolrDotnetSample.Repositories.Abstractions.Relational
{
    public interface IRelationalRepository<TEntity, in TId> : IRepository<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct { }
}