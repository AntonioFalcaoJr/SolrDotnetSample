using AutoMapper;
using SolrDotnetSample.Domain.Abstractions;
using SolrDotnetSample.Repositories.Abstractions.NoSql;
using SolrDotnetSample.Services.Models;

namespace SolrDotnetSample.Services.Abstractions.NoSql
{
    public abstract class NoSqlService<TEntity, TModel, TId> : Service<TEntity, TModel, TId>, INoSqlService<TEntity, TModel, TId>
        where TEntity : Entity<TId>
        where TModel : Model<TId>
        where TId : struct
    {
        protected NoSqlService(INoSqlRepository<TEntity, TId> repository, IMapper mapper)
            : base(repository, mapper) { }
    }
}