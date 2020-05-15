using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using poc_console_solr.Domain.Abstractions;
using SolrNet;

namespace SolrDotnetSample.Repositories.Abstractions.NoSql
{
    public abstract class NoSqlRepository<TEntity, TId> : INoSqlRepository<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct
    {
        private readonly ISolrOperations<TEntity> _solrOperations;

        protected NoSqlRepository(ISolrOperations<TEntity> solrOperations)
        {
            _solrOperations = solrOperations;
        }

        public virtual void Delete(TId id)
        {
            _solrOperations.Delete(id.ToString());
            _solrOperations.Commit();
        }

        public virtual async Task DeleteAsync(TId id, CancellationToken cancellationToken)
        {
            await _solrOperations.DeleteAsync(id.ToString());
            await _solrOperations.CommitAsync();
        }

        public virtual bool Exists(TId id) => throw new NotImplementedException();

        public virtual Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken) => throw new NotImplementedException();

        public virtual void Insert(TEntity entity)
        {
            _solrOperations.Add(entity);
            _solrOperations.Commit();
        }

        public virtual async Task InsertAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await _solrOperations.AddAsync(entity);
            await _solrOperations.CommitAsync();
        }

        public virtual IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> predicate)
        {
            var queryByField = new SolrQueryByField("Id", "1");
            return _solrOperations.Query(queryByField);
        }

        public virtual async Task<IEnumerable<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
        {
            var queryByField = new SolrQueryByField("Id", "1");
            return await _solrOperations.QueryAsync(queryByField, cancellationToken);
        }

        public virtual void Update(TEntity entity) => Insert(entity);

        public virtual async Task UpdateAsync(TEntity entity, CancellationToken cancelletionToken)
            => await InsertAsync(entity, cancelletionToken);
    }
}