using IronSwords.Repositories.Entities;
using IronSwords.Repositories.Interfaces;
using IronSwords.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<User> AddAsync(User user)
        {
            return _userRepository.AddAsync(user);
        }

        public Task DeleteAsync(int id)
        {
           return _userRepository.DeleteAsync(id);
        }

        public Task<List<User>> GetAllAsync()
        {
            return _userRepository.GetAllAsync();
        }

        public Task<User> GetByIdAsync(int id)
        {
          return (_userRepository.GetByIdAsync(id));
        }

        public Task<User> UpdateAsync(User user)
        {
            return _userRepository.UpdateAsync(user);
        }
    }
}
