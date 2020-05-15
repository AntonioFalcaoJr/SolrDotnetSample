using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using poc_console_solr.Domain.Abstractions;
using poc_console_solr.Services.Models;

namespace poc_console_solr.Services.Abstractions
{
    public interface IService<TEntity, in TModel, in TId>
        where TEntity : Entity<TId>
        where TModel : Model<TId>
        where TId : struct
    {
        void Delete(TId id);
        Task DeleteAsync(TId id, CancellationToken cancellationToken);

        TEntity Edit(TModel model);
        Task<TEntity> EditAsync(TModel model, CancellationToken cancellationToken);

        bool Exists(TId id);
        Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        TEntity Save(TModel model);
        Task<TEntity> SaveAsync(TModel model, CancellationToken cancellationToken);
    }
}