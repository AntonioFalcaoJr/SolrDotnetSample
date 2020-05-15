using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using SolrDotnetSample.Domain.Abstractions;
using SolrDotnetSample.Repositories.Abstractions.Relational;
using SolrDotnetSample.Services.Models;

namespace SolrDotnetSample.Services.Abstractions
{
    public abstract class RelationalService<TEntity, TModel, TId> : IService<TEntity, TModel, TId>
        where TEntity : Entity<TId>
        where TModel : Model<TId>
        where TId : struct
    {
        private readonly IMapper _mapper;
        private readonly IRelationalRepository<TEntity, TId> _repository;

        protected RelationalService(IRelationalRepository<TEntity, TId> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Delete(TId id)
        {
            if (Equals(id, Guid.Empty)) return;
            _repository.Delete(id);
        }

        public async Task DeleteAsync(TId id, CancellationToken cancellationToken)
        {
            if (Equals(id, Guid.Empty)) return;
            await _repository.DeleteAsync(id, cancellationToken);
        }

        public TEntity Edit(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            if (entity.Valid) _repository.Update(entity);
            return entity;
        }

        public async Task<TEntity> EditAsync(TModel model, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(model);
            if (entity.Valid) await _repository.UpdateAsync(entity, cancellationToken);
            return entity;
        }

        public bool Exists(TId id) => _repository.Exists(id);

        public async Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken) =>
            await _repository.ExistsAsync(id, cancellationToken);

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate) => _repository.Select(predicate);

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
            => await _repository.SelectAsync(predicate, cancellationToken);

        public TEntity Save(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            if (entity.Valid) _repository.Insert(entity);
            return entity;
        }

        public async Task<TEntity> SaveAsync(TModel model, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(model);
            if (entity.Valid) await _repository.InsertAsync(entity, cancellationToken);
            return entity;
        }
    }
}