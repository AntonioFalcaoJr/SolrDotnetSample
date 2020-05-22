using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Services;
using SolrDotnetSample.Services.Dtos;

namespace SolrDotnetSample.WebApi.Controllers.v1
{
    [ApiVersion("1")]
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
        public IActionResult Delete(Guid id)
        {
            if (Guid.Empty == id) return BadRequest("Identificador inválido.");
            if (_postService.Exists(id) == false) return NotFound();
            _postService.Delete(id);
            return Accepted();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetAll()
        {
            var posts = _postService.GetAll(x => x.Valid);
            if (posts?.Any() == false) return NoContent();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            if (Guid.Empty == id) return BadRequest("Identificador inválido.");
            var post = _postService.GetById(id);
            if (post is null) return NotFound();
            if (post.Valid == false) return BadRequest(post.Notification.Error);
            return Ok(post);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostDto dto)
        {
            if (dto.Id.HasValue && _postService.Exists(dto.Id.Value)) return Conflict();
            var entity = _mapper.Map<Post>(dto);
            entity = _postService.Save(entity);
            if (entity.Valid == false) return BadRequest(entity.Notification.Error);

            return CreatedAtAction(nameof(GetById),
                new {id = entity.Id, version = HttpContext.GetRequestedApiVersion()?.ToString()}, entity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] PostDto dto)
        {
            if (Guid.Empty == id) return BadRequest("Identificador inválido.");
            if (dto?.Id != id) return UnprocessableEntity("Identificador diverge do objeto solicitado.");
            if (_postService.Exists(id) == false) return NotFound();
            var entity = _mapper.Map<Post>(dto);
            entity = _postService.Edit(entity);
            if (entity.Valid == false) return BadRequest(entity.Notification.Error);
            return Ok(entity);
        }
    }
}