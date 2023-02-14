using Application.DTOs;
using Application.Features.Commands.City.CreateCity;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<City, CreateCityCommand>().ReverseMap();
        }
    }
}
