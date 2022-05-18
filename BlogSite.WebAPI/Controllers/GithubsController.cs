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
    public class GithubsController : ControllerBase
    {
        private readonly IGithubService _service;
        private readonly IMapper _mapper;
        public GithubsController(IGithubService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dataList = _service.GetAll();
            return Ok(_mapper.Map<IEnumerable<GithubDto>>(dataList));
        }

        [HttpPost]
        public async Task<IActionResult> Add(GithubDto dto)
        {
            var data = _mapper.Map<Github>(dto);
            await _service.AddAsync(data);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(GithubDto dto)
        {
            var data = _mapper.Map<Github>(dto);
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


