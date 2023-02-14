using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.City.CreateCity
{
    public class CreateCityCommand : IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }
        public string Population { get; set; }
    }
}
