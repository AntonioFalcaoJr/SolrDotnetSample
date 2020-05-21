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
            if (Equals(id, default)) return;
            var model = SelectById(id);
            if (model is null) return;
            _dbSet.Remove(model);
            _context.SaveChanges();
        }

        public virtual async Task DeleteAsync(TId id, CancellationToken cancellationToken)
        {
            if (Equals(id, default)) return;
            var model = await SelectByIdAsync(id, cancellationToken).ConfigureAwait(false);
            if (model is null) return;
            _dbSet.Remove(model);
            await _context.SaveChangesAsync(true, cancellationToken);
        }

        public virtual bool Exists(TId id)
            => Equals(id, default) ? default : _dbSet.Any(x => Equals(x.Id, id));

        public virtual async Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken)
            => Equals(id, default) ? default : await _dbSet.AnyAsync(x => Equals(x.Id, id), cancellationToken);

        public virtual void Insert(TModel model)
        {
            if (model is null || Exists(model.Id)) return;
            _dbSet.Add(model);
            _context.SaveChanges();
        }

        public virtual async Task InsertAsync(TModel model, CancellationToken cancellationToken)
        {
            if (model is null || await ExistsAsync(model.Id, cancellationToken).ConfigureAwait(false)) return;
            await _dbSet.AddAsync(model, cancellationToken);
            await _context.SaveChangesAsync(true, cancellationToken);
        }

        public void InsertMany(IEnumerable<TModel> models)
        {
            models = models as TModel[] ?? models.ToArray();
            if (models.Any() == false) return;
            _dbSet.AddRange(models);
            _context.SaveChanges();
        }

        public async Task InsertManyAsync(IEnumerable<TModel> models, CancellationToken cancellationToken)
        {
            models = models as TModel[] ?? models.ToArray();
            if (models.Any() == false) return;
            await _dbSet.AddRangeAsync(models, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public virtual IEnumerable<TModel> SelectAll(Expression<Func<TModel, bool>> predicate)
            => predicate is null ? default : _dbSet.AsNoTracking().Where(predicate);

        public virtual async Task<IEnumerable<TModel>> SelectAllAsync(Expression<Func<TModel, bool>> predicate, CancellationToken cancellationToken)
            => predicate is null ? default : await _dbSet.AsNoTracking().Where(predicate).ToArrayAsync(cancellationToken);

        public TModel SelectById(TId id)
            => Equals(id, default) ? default : _dbSet.AsNoTracking().FirstOrDefault(model => Equals(model.Id, id));

        public async Task<TModel> SelectByIdAsync(TId id, CancellationToken cancellationToken)
            => Equals(id, default) ? default : await _dbSet.AsNoTracking().FirstOrDefaultAsync(model => Equals(model.Id, id), cancellationToken);

        public virtual void Update(TModel model)
        {
            if (model is null || Exists(model.Id) == false) return;
            _dbSet.Update(model);
            _context.SaveChanges();
        }

        public virtual async Task UpdateAsync(TModel model, CancellationToken cancellationToken)
        {
            if (model is null || await ExistsAsync(model.Id, cancellationToken).ConfigureAwait(false) == false) return;
            _dbSet.Update(model);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}