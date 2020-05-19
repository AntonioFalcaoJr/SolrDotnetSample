using AutoMapper;
using SolrDotnetSample.Domain.Abstractions;
using SolrDotnetSample.Repositories.Abstractions;
using SolrDotnetSample.Repositories.Abstractions.Relational;

namespace SolrDotnetSample.Services.Abstractions.Relational
{
    public abstract class RelationalService<TEntity, TModel, TId> : Service<TEntity, TModel, TId>, IRelationalService<TEntity, TModel, TId>
        where TEntity : Entity<TId>
        where TModel : Model<TId>
        where TId : struct
    {
        protected RelationalService(IRelationalRepository<TEntity, TId> repository, IMapper mapper)
            : base(repository, mapper) { }
    }
}