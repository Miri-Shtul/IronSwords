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
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly MyDbContext _context;
        public AccommodationRepository(MyDbContext context)
        {
            _context = context;
        }
        public async Task<Accommodation> AddAsync(Accommodation accommodation)
        {
            var newAccomodation = _context.Accommodations.Add(accommodation);
            await _context.SaveChangesAsync();
            return newAccomodation.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Accommodations.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Accommodation>> GetAllAsync()
        {
            return await _context.Accommodations.ToListAsync();
        }

        public async Task<Accommodation> GetByIdAsync(int id)
        {
            return await _context.Accommodations.FindAsync(id);
        }

        public async Task<Accommodation> UpdateAsync(Accommodation accommodation)
        {
            var updatedAccommodation = await GetByIdAsync(accommodation.Id);
            updatedAccommodation.NumberOfBeds = accommodation.NumberOfBeds;
            updatedAccommodation.Photos = accommodation.Photos;
            updatedAccommodation.Location = accommodation.Location;
            updatedAccommodation.Title = accommodation.Title;
            updatedAccommodation.IsAvailable = accommodation.IsAvailable;
            await _context.SaveChangesAsync();
            return updatedAccommodation;
        }
    }
}
