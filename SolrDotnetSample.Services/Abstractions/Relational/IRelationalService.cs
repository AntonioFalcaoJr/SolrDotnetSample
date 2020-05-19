using SolrDotnetSample.Domain.Abstractions;
using SolrDotnetSample.Repositories.Abstractions;

namespace SolrDotnetSample.Services.Abstractions.Relational
{
    public interface IRelationalService<TEntity, in TModel, in TId> : IService<TEntity, TModel, TId>
        where TEntity : Entity<TId>
        where TModel : Model<TId>
        where TId : struct { }
}