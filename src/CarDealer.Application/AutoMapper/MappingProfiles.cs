using AutoMapper;
using CarDealer.Application.ViewModel;
using CarDealer.Domain.Model;
using CarDealer.Domain.Model.Base;

namespace CarDealer.Application.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<BaseModel, BaseViewModel>().ReverseMap();
            CreateMap<Car, CarViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
