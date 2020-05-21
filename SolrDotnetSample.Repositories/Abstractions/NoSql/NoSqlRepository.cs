using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolrNet;

namespace SolrDotnetSample.Repositories.Abstractions.NoSql
{
    public abstract class NoSqlRepository<TModel, TId> : INoSqlRepository<TModel, TId>
        where TModel : Model<TId>
        where TId : struct
    {
        private const string IdField = "id";
        private readonly ISolrOperations<TModel> _solrOperations;

        protected NoSqlRepository(ISolrOperations<TModel> solrOperations)
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

        public virtual void Insert(TModel model)
        {
            _solrOperations.Add(model);
            _solrOperations.Commit();
        }

        public virtual async Task InsertAsync(TModel model, CancellationToken cancellationToken)
        {
            await _solrOperations.AddAsync(model);
            await _solrOperations.CommitAsync();
        }

        public IEnumerable<TModel> SelectAll(Expression<Func<TModel, bool>> predicate)
            => throw new NotImplementedException();

        public Task<IEnumerable<TModel>> SelectAllAsync(Expression<Func<TModel, bool>> predicate, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public virtual void Update(TModel model) => Insert(model);

        public virtual async Task UpdateAsync(TModel model, CancellationToken cancelletionToken)
            => await InsertAsync(model, cancelletionToken);

        public virtual TModel SelectById(TId id)
        {
            var queryByField = new SolrQueryByField(IdField, id.ToString());
            return _solrOperations.Query(queryByField).FirstOrDefault();
        }

        public virtual async Task<TModel> SelectByIdAsync(TId id, CancellationToken cancellationToken)
        {
            var queryByField = new SolrQueryByField(IdField, "3bbee7fa-98bd-4d7b-ad87-223a68599079".ToString()) {Quoted = false};
            var result = await _solrOperations.QueryAsync(queryByField, cancellationToken);
            return result?.FirstOrDefault();
        }
    }
}