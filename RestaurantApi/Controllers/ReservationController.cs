using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApi.CQRS.Commands.Request;
using RestaurantApi.CQRS.Commands.Response;
using RestaurantApi.CQRS.Queries.Request;
using RestaurantApi.CQRS.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        IMediator _mediator;

        public ReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/Empty_Tables")]
        public async Task<IActionResult> Get([FromQuery] GetEmptyTablesQueryRequest requestModel)
        {
            List<GetEmptyTablesQueryResponse> emptyTables = await _mediator.Send(requestModel);
            return Ok(emptyTables);
        }


        [HttpPost]
        [Route("/Create_Customer")]
        public async Task<IActionResult> Create([FromBody] CreateCustomerCommandRequest requestModel)
        {
            CreateCustomerCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpDelete]
        [Route("/Delete_Customer")]
        public async Task<IActionResult> Delete([FromQuery]DeleteCustomerCommandRequest requestModel)
        {
            DeleteCustomerCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
