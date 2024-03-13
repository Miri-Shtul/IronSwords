using AutoMapper;
using IronSwords.Repositories.Entities;
using IronSwords.WebApi.Models;

namespace IronSwords.WebApi
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Accommodation, AccommodationModel>().ReverseMap();
        }
    }
}
