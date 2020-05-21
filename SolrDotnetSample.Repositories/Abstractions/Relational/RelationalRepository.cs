using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SolrDotnetSample.Repositories.Abstractions.Relational
{
    public abstract class RelationalRepository<TModel, TId> : IRelationalRepository<TModel, TId>
        where TModel : Model<TId>
        where TId : struct
    {
        private readonly DbContext _context;
        private readonly DbSet<TModel> _dbSet;

        protected RelationalRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TModel>();
        }

        public virtual void Delete(TId id)
        {
            var enumerable = SelectAll(x => Equals(x.Id, id));
            if (enumerable is null || enumerable.Any() == false) return;

            _dbSet.RemoveRange(enumerable);
            _context.SaveChanges();
        }

        public virtual async Task DeleteAsync(TId id, CancellationToken cancellationToken)
        {
            var enumerable = await SelectAllAsync(x => Equals(x.Id, id), cancellationToken).ConfigureAwait(false);
            if (enumerable is null || enumerable.Any() == false) return;

            _dbSet.RemoveRange(enumerable);
            await _context.SaveChangesAsync(true, cancellationToken);
        }

        public virtual bool Exists(TId id) => _dbSet.Any(x => Equals(x.Id, id));

        public virtual async Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken)
            => await _dbSet.AnyAsync(x => Equals(x.Id, id), cancellationToken);

        public virtual void Insert(TModel model)
        {
            if (Exists(model.Id)) return;
            _dbSet.Add(model);
            _context.SaveChanges();
        }

        public virtual async Task InsertAsync(TModel model, CancellationToken cancellationToken)
        {
            if (await ExistsAsync(model.Id, cancellationToken).ConfigureAwait(false)) return;
            await _dbSet.AddAsync(model, cancellationToken);
            await _context.SaveChangesAsync(true, cancellationToken);
        }

        public virtual IEnumerable<TModel> SelectAll(Expression<Func<TModel, bool>> predicate)
            => _dbSet.AsNoTracking().Where(predicate);

        public virtual async Task<IEnumerable<TModel>> SelectAllAsync(Expression<Func<TModel, bool>> predicate, CancellationToken cancellationToken)
            => await _dbSet.AsNoTracking().Where(predicate).ToArrayAsync(cancellationToken);

        public TModel SelectById(TId id)
            => _dbSet.AsNoTracking().FirstOrDefault(model => Equals(model.Id, id));

        public async Task<TModel> SelectByIdAsync(TId id, CancellationToken cancellationToken)
            => await _dbSet.AsNoTracking().FirstOrDefaultAsync(model => Equals(model.Id, id), cancellationToken);

        public virtual void Update(TModel model)
        {
            if (Exists(model.Id) == false) return;
            _dbSet.Update(model);
            _context.SaveChanges();
        }

        public virtual async Task UpdateAsync(TModel model, CancellationToken cancellationToken)
        {
            if (await ExistsAsync(model.Id, cancellationToken).ConfigureAwait(false) == false) return;
            _dbSet.Update(model);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}