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
    public class TwittersController : ControllerBase
    {

        private readonly ITwitterService _twitterService;
        private readonly IMapper _mapper;
        public TwittersController(ITwitterService twitterService, IMapper mapper)
        {
            _twitterService = twitterService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var twitters = _twitterService.GetAll();
            var twitterDto = _mapper.Map<List<TwitterDto>>(twitters);
            return Ok(twitterDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var twitter = _twitterService.GetByIdAsync(id);
            return Ok(twitter);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TwitterDto twitter)
        {
            var twitterEntity = _mapper.Map<Twitter>(twitter);
            await _twitterService.AddAsync(twitterEntity);
            return Ok(twitterEntity);

        }

        [HttpPut]
        public IActionResult Update(TwitterDto twitterDto)
        {
            var twitter = _mapper.Map<Twitter>(twitterDto);
            _twitterService.Update(twitter);
            return Ok(twitter);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var twitter = await _twitterService.GetByIdAsync(id);
            _twitterService.Delete(twitter);
            return Ok();
        }
    }
}
