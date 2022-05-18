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
    public class FacebooksController : ControllerBase
    {
        private readonly IFacebookService _service;
        private readonly IMapper _mapper;
        public FacebooksController(IFacebookService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dataList = _service.GetAll();
            return Ok(_mapper.Map<IEnumerable<FacebookDto>>(dataList));
        }

        [HttpPost]
        public async Task<IActionResult> Add(FacebookDto dto)
        {
            var data = _mapper.Map<Facebook>(dto);
            await _service.AddAsync(data);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(FacebookDto dto)
        {
            var data = _mapper.Map<Facebook>(dto);
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
