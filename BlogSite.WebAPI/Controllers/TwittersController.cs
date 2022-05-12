using AutoMapper;
using BlogSite.Core.Dtos;
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

    }
}
