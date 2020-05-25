using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolrDotnetSample.Domain.Abstractions;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services.Abstractions;

namespace SolrDotnetSample.WebApi.Abstractions
{
    [ApiController, Route("api/v{version:apiVersion}/[controller]")]
    public abstract class SolrDotnetSampleControllerBase<TEntity, TDto, TId> : ControllerBase
        where TEntity : Entity<TId>
        where TDto : Dto<TId>
        where TId : struct
    {
        private readonly IMapper _mapper;
        private readonly IService<TEntity, TId> _service;

        protected SolrDotnetSampleControllerBase(IService<TEntity, TId> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(TId id, CancellationToken cancellationToken)
        {
            if (Equals(id, default(TId))) return BadRequest("Identificador inválido.");
            if (await _service.ExistsAsync(id, cancellationToken) == false) return NotFound();
            await _service.DeleteAsync(id, cancellationToken);
            return Accepted();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetAllAsync(CancellationToken cancellationToken)
        {
            var posts = await _service.GetAllAsync(x => Equals(x.Id, default) == false, cancellationToken);
            if (posts?.Any() == false) return NoContent();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(TId id, CancellationToken cancellationToken)
        {
            if (Equals(id, default(TId))) return BadRequest("Identificador inválido.");
            var post = await _service.GetByIdAsync(id, cancellationToken);
            if (post is null) return NotFound();
            if (post.Valid == false) return BadRequest(post.Notification.Error);
            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] TDto dto, CancellationToken cancellationToken)
        {
            if (dto.Id.HasValue && await _service.ExistsAsync(dto.Id.Value, cancellationToken)) return Conflict();
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _service.SaveAsync(entity, cancellationToken);
            if (entity.Valid == false) return BadRequest(entity.Notification.Error);

            return CreatedAtAction(nameof(GetByIdAsync),
                new {id = entity.Id, cancellationToken, version = HttpContext.GetRequestedApiVersion()?.ToString()}, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(TId id, [FromBody] TDto dto, CancellationToken cancellationToken)
        {
            if (Equals(id, default(TId))) return BadRequest("Identificador inválido.");
            if (Equals(dto.Id, id) == false) return UnprocessableEntity("Identificador diverge do objeto solicitado.");
            if (await _service.ExistsAsync(id, cancellationToken) == false) return NotFound();
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _service.EditAsync(entity, cancellationToken);
            if (entity.Valid == false) return BadRequest(entity.Notification.Error);
            return Ok(entity);
        }
    }
}