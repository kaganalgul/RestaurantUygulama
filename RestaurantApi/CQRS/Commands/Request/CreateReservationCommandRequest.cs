using RestaurantApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApi.CQRS.Commands.Request
{
    public class CreateReservationCommandRequest
    {
        public int TableId { get; set; }

        public Table Table { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string ReservationTime { get; set; }
    }
}
