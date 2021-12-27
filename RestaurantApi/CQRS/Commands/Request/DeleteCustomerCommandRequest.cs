using MediatR;
using RestaurantApi.CQRS.Commands.Response;
using System;

namespace RestaurantApi.CQRS.Commands.Request
{
    public class DeleteCustomerCommandRequest : IRequest<DeleteCustomerCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
