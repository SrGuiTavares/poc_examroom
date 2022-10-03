using AutoMapper;
using CarDealer.Application.ViewModel;
using CarDealer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Application.AutoMapper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Car, CarViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
