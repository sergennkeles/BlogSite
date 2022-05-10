using AutoMapper;
using BlogSite.Core.Dtos;
using BlogSite.Core.Services;
using BlogSite.Core.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.WebAPI.Controllers
{

    public class UsersController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var users = _userService.GetAll();
            var usersDto = _mapper.Map<List<UserInfoDto>>(users);
            return Ok(usersDto);
        }

    }
}
