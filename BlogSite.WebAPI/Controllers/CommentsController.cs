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
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _service;
        private readonly IMapper _mapper;
        public CommentsController(ICommentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dataList = _service.GetAll();
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(dataList));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CommentDto dto)
        {
            var data = _mapper.Map<Comment>(dto);
            await _service.AddAsync(data);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(CommentDto dto)
        {
            var data = _mapper.Map<Comment>(dto);
            _service.Update(data);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedData = await _service.GetByIdAsync(id);
            _service.Delete(deletedData);
            return Ok();
        }
    }
}
