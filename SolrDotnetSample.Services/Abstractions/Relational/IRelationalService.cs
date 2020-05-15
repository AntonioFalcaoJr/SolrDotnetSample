using SolrDotnetSample.Domain.Abstractions;
using SolrDotnetSample.Services.Models;

namespace SolrDotnetSample.Services.Abstractions.Relational
{
    public interface IRelationalService<TEntity, in TModel, in TId> : IService<TEntity, TModel, TId>
        where TEntity : Entity<TId>
        where TModel : Model<TId>
        where TId : struct { }
}