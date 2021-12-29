using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApi.Models.Entity
{
    public class Reservation
    {
        public Guid Id { get; set; }

        public int TableId { get; set; }

        public Table Table { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public List<string> ReservationTime { get; set; } = new List<string> { "19:00", "20:00", "21:00", "22:00" };
    }
}
