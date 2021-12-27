using System;

namespace RestaurantApi.Models.Entity
{
    public class Table
    {
        public int Id { get; set; }

        public bool IsEmpty { get; set; } = true;

        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
