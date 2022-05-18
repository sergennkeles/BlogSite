using AutoMapper;
using BlogSite.Core.Dtos;
using BlogSite.Core.Entities;
using BlogSite.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;
        public PostsController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
            
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var posts = _postService.GetAll();
            return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            await _postService.AddAsync(post);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            _postService.Update(post);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedPost = await _postService.GetByIdAsync(id);
            _postService.Delete(deletedPost);
            return Ok();
        }
    }
}
