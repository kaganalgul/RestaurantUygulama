using MediatR;
using RestaurantApi.CQRS.Commands.Request;
using RestaurantApi.CQRS.Commands.Response;
using RestaurantApi.Models.Data;
using RestaurantApi.Models.Entity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantApi.CQRS.Handlers.CommandHandlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        private readonly DatabaseContext _db;

        public CreateCustomerCommandHandler(DatabaseContext db)
        {
            _db = db;
        }       

        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            _db.Customers.Add(new Customer()
            { 
                Id = id,
                FullName = request.FullName,
                ReservationTime = $"{DateTime.Now.Date.ToString("dd/MM/yyyy")} {request.ReservationTime}",
                TableId = request.TableId
            });

            Table table = _db.Tables.Find(request.TableId);
            table.IsEmpty = false;

            await _db.SaveChangesAsync();

            return new CreateCustomerCommandResponse()
            {
                IsSuccess = true,
                CustomerId = id
            };
        }
    }
}
