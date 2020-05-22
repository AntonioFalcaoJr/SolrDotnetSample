using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services;
using SolrDotnetSample.Services.Dtos;

namespace SolrDotnetSample.WebApi.Controllers.v2
{
    [ApiVersion("2")]
    public class PostsController : PostsControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPostService _postService;

        public PostsController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            if (Guid.Empty == id) return BadRequest("Identificador inválido.");
            if (await _postService.ExistsAsync(id, cancellationToken) == false) return NotFound();
            await _postService.DeleteAsync(id, cancellationToken);
            return Accepted();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetAllAsync(CancellationToken cancellationToken)
        {
            var posts = await _postService.GetAllAsync(x => x.Valid, cancellationToken);
            if (posts?.Any() == false) return NoContent();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            if (Guid.Empty == id) return BadRequest("Identificador inválido.");
            var post = await _postService.GetByIdAsync(id, cancellationToken);
            if (post is null) return NotFound();
            if (post.Valid == false) return BadRequest(post.Notification.Error);
            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] PostDto dto, CancellationToken cancellationToken)
        {
            if (dto.Id.HasValue && await _postService.ExistsAsync(dto.Id.Value, cancellationToken)) return Conflict();
            var entity = _mapper.Map<Post>(dto);
            entity = await _postService.SaveAsync(entity, cancellationToken);
            if (entity.Valid == false) return BadRequest(entity.Notification.Error);

            return CreatedAtAction(nameof(GetByIdAsync),
                new {id = entity.Id, cancellationToken, version = HttpContext.GetRequestedApiVersion()?.ToString()}, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(Guid id, [FromBody] PostDto dto, CancellationToken cancellationToken)
        {
            if (Guid.Empty == id) return BadRequest("Identificador inválido.");
            if (dto?.Id != id) return UnprocessableEntity("Identificador diverge do objeto solicitado.");
            if (await _postService.ExistsAsync(id, cancellationToken) == false) return NotFound();
            var entity = _mapper.Map<Post>(dto);
            entity = await _postService.EditAsync(entity, cancellationToken);
            if (entity.Valid == false) return BadRequest(entity.Notification.Error);
            return Ok(entity);
        }
    }
}