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
    public class FavoritesController : ControllerBase
    {

        private readonly IFavoriteService _service;
        private readonly IMapper _mapper;
        public FavoritesController(IFavoriteService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dataList = _service.GetAll();
            return Ok(_mapper.Map<IEnumerable<Favorite>>(dataList));
        }

        [HttpPost]
        public async Task<IActionResult> Add(FavoriteDto dto)
        {
            var data = _mapper.Map<Favorite>(dto);
            await _service.AddAsync(data);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(FavoriteDto dto)
        {
            var data = _mapper.Map<Favorite>(dto);
            _service.Update(data);
            return Ok();
        }
        
        [HttpPatch]
        public IActionResult IsDeleted(IsDeletedFavoriteDto dto)
        {

            var data = _mapper.Map<Favorite>(dto);
            _service.Update(data);
            return Ok();
        }
    }
}
