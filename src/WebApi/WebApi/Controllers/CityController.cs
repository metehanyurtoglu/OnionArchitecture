using Application.Features.Commands.City.CreateCity;
using Application.Features.Queries.City.GetAll;
using Application.Features.Queries.City.GetById;
using Application.Interfaces.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IMediator  mediator;

        public CityController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetAllCities()
        {
            var query = new GetAllCitiesQuery();

            return Ok(await this.mediator.Send(query));
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetCityById(Guid id)
        {
            var query = new GetCityByIdQuery{
                Id = id
            };

            return Ok(await this.mediator.Send(query));
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> CreateCity(CreateCityCommand command)
        {
            return Ok(await this.mediator.Send(command));
        }
    }
}
