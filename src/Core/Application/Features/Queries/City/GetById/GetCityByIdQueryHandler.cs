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

namespace Application.Features.Queries.City.GetById
{
    public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, ServiceResponse<CityDTO>>
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper;

        public GetCityByIdQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<CityDTO>> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            var city = await this.cityRepository.GetByIdAsync(request.Id);
            var viewModel = this.mapper.Map<CityDTO>(city);

            return new ServiceResponse<CityDTO>(viewModel);
        }
    }
}
