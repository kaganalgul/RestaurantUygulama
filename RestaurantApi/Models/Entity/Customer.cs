using System;

namespace RestaurantApi.Models.Entity
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public Reservation Reservation { get; set; }

        public Guid ReservationId { get; set; }
    }
}
