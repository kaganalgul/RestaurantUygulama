using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApi.Models.EntityConfigurations
{
    public class ReservationEntityConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ReservationTime).HasDefaultValueSql("getutcdate()");

            builder.HasOne(x => x.Customer).WithOne(x => x.Reservation).HasForeignKey<Reservation>(x => x.CustomerId);

            builder.HasOne(x => x.Table).WithOne(x => x.Reservation).HasForeignKey<Reservation>(x => x.TableId);
        }
    }
}
