using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using SolrDotnetSample.Domain.Abstractions;

namespace SolrDotnetSample.Repositories.Abstractions
{
    public interface IRepository<TEntity, in TId>
        where TEntity : Entity<TId>
        where TId : struct
    {
        void Delete(TId id);
        Task DeleteAsync(TId id, CancellationToken cancellationToken);

        bool Exists(TId id);
        Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken);

        void Insert(TEntity entity);
        Task InsertAsync(TEntity entity, CancellationToken cancellationToken);

        IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        void Update(TEntity entity);
        Task UpdateAsync(TEntity entity, CancellationToken cancelletionToken);
    }
}