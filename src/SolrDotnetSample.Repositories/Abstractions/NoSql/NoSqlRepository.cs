using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
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
            if (Equals(id, default(TId))) return;
            _solrOperations.Delete(id.ToString());
            _solrOperations.Commit();
        }

        public virtual async Task DeleteAsync(TId id, CancellationToken cancellationToken)
        {
            if (Equals(id, default(TId))) return;
            await _solrOperations.DeleteAsync(id.ToString());
            await _solrOperations.CommitAsync();
        }

        public virtual bool Exists(TId id)
            => Equals(id, default(TId)) ? default : SelectById(id) is {};

        public virtual async Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken)
            => Equals(id, default(TId)) ? default : await SelectByIdAsync(id, cancellationToken) is {};

        public virtual void Insert(TModel model)
        {
            if (model is null) return;
            _solrOperations.Add(model);
            _solrOperations.Commit();
        }

        public virtual async Task InsertAsync(TModel model, CancellationToken cancellationToken)
        {
            if (model is null) return;
            await _solrOperations.AddAsync(model);
            await _solrOperations.CommitAsync();
        }

        public IEnumerable<TModel> SelectAll(Expression<Func<TModel, bool>> predicate)
            => predicate is null ? default : _solrOperations.Query(SolrQuery.All);

        public async Task<IEnumerable<TModel>> SelectAllAsync(Expression<Func<TModel, bool>> predicate, CancellationToken cancellationToken)
            => predicate is null ? default : await _solrOperations.QueryAsync(SolrQuery.All, cancellationToken);

        public virtual void Update(TModel model)
        {
            if (model is null) return;
            Insert(model);
        }

        public virtual async Task UpdateAsync(TModel model, CancellationToken cancelletionToken)
        {
            if (model is null) return;
            await InsertAsync(model, cancelletionToken);
        }

        public virtual TModel SelectById(TId id)
        {
            if (Equals(id, default(TId))) return default;
            var queryByField = new SolrQueryByField(IdField, id.ToString());
            return _solrOperations.Query(queryByField).FirstOrDefault();
        }

        public virtual async Task<TModel> SelectByIdAsync(TId id, CancellationToken cancellationToken)
        {
            if (Equals(id, default(TId))) return default;
            var queryByField = new SolrQueryByField(IdField, id.ToString()) {Quoted = false};
            var solrQueryResults = await _solrOperations.QueryAsync(queryByField, cancellationToken);
            return solrQueryResults?.FirstOrDefault();
        }

        public virtual void InsertMany(IEnumerable<TModel> models)
        {
            models = models as TModel[] ?? models.ToArray();
            if (models.Any() == false) return;
            _solrOperations.AddRange(models);
            _solrOperations.Commit();
        }

        public virtual async Task InsertManyAsync(IEnumerable<TModel> models, CancellationToken cancellationToken)
        {
            models = models as TModel[] ?? models.ToArray();
            if (models.Any() == false) return;
            await _solrOperations.AddRangeAsync(models);
            await _solrOperations.CommitAsync();
        }
    }
}