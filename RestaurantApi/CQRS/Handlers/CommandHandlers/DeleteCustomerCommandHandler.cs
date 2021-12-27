using MediatR;
using RestaurantApi.CQRS.Commands.Request;
using RestaurantApi.CQRS.Commands.Response;
using RestaurantApi.Models.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantApi.CQRS.Handlers.CommandHandlers
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, DeleteCustomerCommandResponse>
    {
        readonly DatabaseContext _db;

        public DeleteCustomerCommandHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<DeleteCustomerCommandResponse> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedCustomer = _db.Customers.FirstOrDefault(x => x.Id.Equals(request.Id));
            _db.Customers.Remove(deletedCustomer);
            await _db.SaveChangesAsync();

            return new DeleteCustomerCommandResponse()
            {
                IsSuccess = true
            };
        }
    }
}
