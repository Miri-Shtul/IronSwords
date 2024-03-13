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
    public class AccommodationService:IAccommodationService
    {
        private readonly IAccommodationRepository _accommodationRepository;
        public AccommodationService(IAccommodationRepository accommodationRepository)
        {
            _accommodationRepository = accommodationRepository;
        }
        public Task<Accommodation> AddAsync(Accommodation accommodation)
        {
            return _accommodationRepository.AddAsync(accommodation);
        }

        public Task DeleteAsync(int id)
        {
           return _accommodationRepository.DeleteAsync(id);
        }

        public Task<List<Accommodation>> GetAllAsync()
        {
            return _accommodationRepository.GetAllAsync();
        }

        public Task<Accommodation> GetByIdAsync(int id)
        {
          return _accommodationRepository.GetByIdAsync(id);
        }

        public Task<Accommodation> UpdateAsync(Accommodation accommodation)
        {
            return _accommodationRepository.UpdateAsync(accommodation);
        }
    }
}
