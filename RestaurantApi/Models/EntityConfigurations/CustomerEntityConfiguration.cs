using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantApi.Models.Entity;

namespace RestaurantApi.Models.EntityConfigurations
{
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ReservationTime).HasDefaultValueSql("getutcdate()");

            builder.HasOne(x => x.Table).WithOne(x => x.Customer).HasForeignKey<Customer>(x => x.TableId);
        }
    }
}
