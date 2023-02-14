using Application.DTOs;
using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.City.GetById
{
    public class GetCityByIdQuery : IRequest<ServiceResponse<CityDTO>>
    {
        public Guid Id { get; set; }
    }
}
