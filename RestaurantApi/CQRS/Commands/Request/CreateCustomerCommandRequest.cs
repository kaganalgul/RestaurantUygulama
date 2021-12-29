using MediatR;
using RestaurantApi.CQRS.Commands.Response;
using RestaurantApi.Models.Entity;
using System;

namespace RestaurantApi.CQRS.Commands.Request
{
    public class CreateCustomerCommandRequest : IRequest<CreateCustomerCommandResponse>
    {
        public string FullName { get; set; }

        public Guid ReservationId { get; set; }
    }
}
