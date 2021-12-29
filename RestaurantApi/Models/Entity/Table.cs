using System;

namespace RestaurantApi.Models.Entity
{
    public class Table
    {
        public int Id { get; set; }

        public bool IsEmpty { get; set; } = true;

        public Reservation Reservation { get; set; }

        public Guid ReservationId { get; set; }
    }
}
