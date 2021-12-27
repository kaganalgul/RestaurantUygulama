using System;

namespace RestaurantApi.Models.Entity
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string ReservationTime { get; set; }

        public Table Table { get; set; }

        public int TableId { get; set; }
    }
}
