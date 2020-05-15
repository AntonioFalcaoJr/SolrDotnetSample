using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using poc_console_solr.Domain.Abstractions;

namespace SolrDotnetSample.Repositories.Abstractions.Relational
{
    public abstract class RelationalRepository<TEntity, TId> : IRelationalRepository<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        protected RelationalRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual void Delete(TId id)
        {
            var entities = Select(x => Equals(x.Id, id));
            if (entities is null || entities.Any() == false) return;

            _dbSet.RemoveRange(entities);
            _context.SaveChanges();
        }

        public virtual async Task DeleteAsync(TId id, CancellationToken cancellationToken)
        {
            var entities = await SelectAsync(x => Equals(x.Id, id), cancellationToken).ConfigureAwait(false);
            if (entities is null || entities.Any() == false) return;

            _dbSet.RemoveRange(entities);
            await _context.SaveChangesAsync(true, cancellationToken);
        }

        public virtual bool Exists(TId id) => _dbSet.Any(x => Equals(x.Id, id));

        public virtual async Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken)
            => await _dbSet.AnyAsync(x => Equals(x.Id, id), cancellationToken);

        public virtual void Insert(TEntity entity)
        {
            if (Exists(entity.Id)) return;

            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public virtual async Task InsertAsync(TEntity entity, CancellationToken cancellationToken)
        {
            if (await ExistsAsync(entity.Id, cancellationToken).ConfigureAwait(false)) return;

            await _dbSet.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(true, cancellationToken);
        }

        public virtual IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> predicate)
            => _dbSet.AsNoTracking().Where(predicate);

        public virtual async Task<IEnumerable<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
            => await _dbSet.AsNoTracking().Where(predicate).ToArrayAsync(cancellationToken);

        public virtual void Update(TEntity entity)
        {
            if (Exists(entity.Id) == false) return;

            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public virtual async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            if (await ExistsAsync(entity.Id, cancellationToken).ConfigureAwait(false) == false) return;

            _dbSet.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}