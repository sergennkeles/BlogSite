using AutoMapper;
using BlogSite.Core.Dtos;
using BlogSite.Core.Entities;
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


        [HttpGet("GetAllUsersInfo")]
        public IActionResult GetUsersInfoDto()
        {
            var users = _userService.GetUsersInfoDtoService();
            var usersDto = _mapper.Map<List<UserInfoDto>>(users);
            return Ok(usersDto);
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAll();
            var usersDto = _mapper.Map<List<UserDto>>(users);
            return Ok(usersDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userService.AddAsync(user);
            return Ok();
        }

        [HttpPut]
        public  IActionResult Update(UserDto userDto)
        {
        
            var user = _mapper.Map<User>(userDto);
            _userService.Update(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedUser = await _userService.GetByIdAsync(id);
            _userService.Delete(deletedUser);
            return Ok();
        }
    }
}
