using IronSwords.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords.Services.Interfaces
{
    public interface IAccommodationService
    {
        Task<List<Accommodation>> GetAllAsync();
        Task<Accommodation> GetByIdAsync(int id);
        Task<Accommodation> AddAsync(Accommodation accommodation);
        Task<Accommodation> UpdateAsync(Accommodation accommodation);
        Task DeleteAsync(int id);
    }
}
