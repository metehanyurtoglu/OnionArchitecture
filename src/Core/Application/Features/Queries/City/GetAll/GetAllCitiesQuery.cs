using Application.DTOs;
using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.City.GetAll
{
    public class GetAllCitiesQuery : IRequest<ServiceResponse<List<CityDTO>>>
    {
    }
}
