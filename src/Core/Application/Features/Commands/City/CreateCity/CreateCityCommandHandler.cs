using Application.Interfaces.Repositories;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.City.CreateCity
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, ServiceResponse<Guid>>
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper;

        public CreateCityCommandHandler(ICityRepository cityRepository, IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<Guid>> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var city = this.mapper.Map<Domain.Entities.City>(request);
            await this.cityRepository.AddAsync(city);

            return new ServiceResponse<Guid>(city.Id);
        }
    }
}
