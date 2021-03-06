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
    public class InstagramsController : ControllerBase
    {
        private readonly IInstagramService _service;
        private readonly IMapper _mapper;
        public InstagramsController(IInstagramService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dataList = _service.GetAll();
            return Ok(_mapper.Map<IEnumerable<InstagramDto>>(dataList));
        }

        [HttpPost]
        public async Task<IActionResult> Add(InstagramDto dto)
        {
            var data = _mapper.Map<Instagram>(dto);
            await _service.AddAsync(data);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(InstagramDto dto)
        {
            var data = _mapper.Map<Instagram>(dto);
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
