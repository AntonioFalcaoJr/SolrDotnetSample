using AutoMapper;
using SolrDotnetSample.Domain.Abstractions;
using SolrDotnetSample.Repositories.Abstractions;
using SolrDotnetSample.Repositories.Abstractions.NoSql;

namespace SolrDotnetSample.Services.Abstractions.NoSql
{
    public abstract class NoSqlService<TEntity, TModel, TDto, TId> : Service<TEntity, TModel, TId>, INoSqlService<TEntity, TId>
        where TEntity : Entity<TId>
        where TModel : Model<TId>
        where TId : struct
    {
        protected NoSqlService(INoSqlRepository<TModel, TId> repository, IMapper mapper)
            : base(repository, mapper) { }
    }
}