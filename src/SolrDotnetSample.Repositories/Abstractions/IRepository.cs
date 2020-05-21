using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace SolrDotnetSample.Repositories.Abstractions
{
    public interface IRepository<TModel, in TId>
        where TModel : Model<TId>
        where TId : struct
    {
        void Delete(TId id);
        Task DeleteAsync(TId id, CancellationToken cancellationToken);

        bool Exists(TId id);
        Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken);

        void Insert(TModel model);
        Task InsertAsync(TModel model, CancellationToken cancellationToken);

        void InsertMany(IEnumerable<TModel> models);
        Task InsertManyAsync(IEnumerable<TModel> models, CancellationToken cancellationToken);

        IEnumerable<TModel> SelectAll(Expression<Func<TModel, bool>> predicate);
        Task<IEnumerable<TModel>> SelectAllAsync(Expression<Func<TModel, bool>> predicate, CancellationToken cancellationToken);

        TModel SelectById(TId id);
        Task<TModel> SelectByIdAsync(TId id, CancellationToken cancellationToken);

        void Update(TModel model);
        Task UpdateAsync(TModel model, CancellationToken cancelletionToken);
    }
}