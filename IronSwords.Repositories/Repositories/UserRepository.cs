using IronSwords.Repositories.Entities;
using IronSwords.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;
        public UserRepository(IContext icontext)
        {
            _context = icontext;
        }
        public async Task<User> AddAsync(User user)
        {
            var newUser = _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return newUser.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Users.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var updatedUser = await GetByIdAsync(user.Id);
            updatedUser.Name = user.Name;
            updatedUser.Email = user.Email;
            await _context.SaveChangesAsync();
            return updatedUser;
        }
    }
}
