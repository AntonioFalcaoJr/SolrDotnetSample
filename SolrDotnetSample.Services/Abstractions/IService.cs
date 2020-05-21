using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using SolrDotnetSample.Domain.Abstractions;

namespace SolrDotnetSample.Services.Abstractions
{
    public interface IService<TEntity, in TId>
        where TEntity : Entity<TId>
        where TId : struct
    {
        void Delete(TId id);
        Task DeleteAsync(TId id, CancellationToken cancellationToken);

        TEntity Edit(TEntity entity);
        Task<TEntity> EditAsync(TEntity entity, CancellationToken cancellationToken);

        bool Exists(TId id);
        Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken);

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        TEntity GetById(TId id);
        Task<TEntity> GetByIdAsync(TId id, CancellationToken cancellationToken);

        TEntity Save(TEntity entity);
        Task<TEntity> SaveAsync(TEntity entity, CancellationToken cancellationToken);
    }
}