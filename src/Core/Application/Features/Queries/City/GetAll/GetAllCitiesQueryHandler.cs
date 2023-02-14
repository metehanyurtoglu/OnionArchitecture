using Application.DTOs;
using Application.Interfaces.Repositories;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.City.GetAll
{
    public class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, ServiceResponse<List<CityDTO>>>
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper;

        public GetAllCitiesQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<List<CityDTO>>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
        {
            var cities = await this.cityRepository.GetAllAsync();
                
            var viewModel = this.mapper.Map<List<CityDTO>>(cities);

            return new ServiceResponse<List<CityDTO>>(viewModel);
        }
    }
}
