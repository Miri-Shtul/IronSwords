using AutoMapper;
using IronSwords.Repositories.Entities;
using IronSwords.Services.Interfaces;
using IronSwords.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IronSwords.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<List<UserModel>> Get()
        {
            return  _mapper.Map<List<UserModel>>(await _userService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<UserModel> GetById(int id)
        {
            return _mapper.Map<UserModel>(await _userService.GetByIdAsync(id));
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<UserModel> Put(int id, [FromBody] UserModel userModel)
        {
            return _mapper.Map<UserModel>(await _userService.UpdateAsync(new User
            {
                Name= userModel.Name,
                Email = userModel.Email,
                IsHost= userModel.IsHost
            }));;;
        }
        [HttpPost]
        public async Task<UserModel> Post([FromBody] User user)
        {
            return _mapper.Map<UserModel>(await _userService.AddAsync(user));
        }
    }
}
