using AutoMapper;
using IronSwords.Repositories.Entities;
using IronSwords.Services.Interfaces;
using IronSwords.Services.Services;
using IronSwords.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Drawing;

namespace IronSwords.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccommodationController : ControllerBase
    {
        private readonly IAccommodationService _accommodationService;
        private readonly IMapper _mapper;
        public AccommodationController(IAccommodationService accommodationService, IMapper mapper)
        {
            _accommodationService = accommodationService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<List<AccommodationModel>> Get()
        {
            return _mapper.Map<List<AccommodationModel>>(await _accommodationService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<AccommodationModel> GetById(int id)
        {
            return _mapper.Map<AccommodationModel>(await _accommodationService.GetByIdAsync(id));
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _accommodationService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<AccommodationModel> Put(int id, [FromBody] AccommodationModel accommodationModel)
        {
            return _mapper.Map<AccommodationModel>(await _accommodationService.UpdateAsync(new Accommodation
            {
                Title = accommodationModel.Title,
                HostId = accommodationModel.HostId,
                Location = accommodationModel.Location,
                Size = accommodationModel.Size,
                NumberOfBeds = (int)(accommodationModel?.NumberOfBeds),
                Photos = accommodationModel?.Photos,
                IsAvailable = accommodationModel != null,
            })); ; ;
        }
        [HttpPost]
        public async Task<AccommodationModel> Post([FromBody] Accommodation accommodation)
        {
            return _mapper.Map<AccommodationModel>(await _accommodationService.AddAsync(accommodation));
        }
    }
}
