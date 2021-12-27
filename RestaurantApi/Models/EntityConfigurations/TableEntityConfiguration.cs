using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantApi.Models.Entity;

namespace RestaurantApi.Models.EntityConfigurations
{
    public class TableEntityConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IsEmpty).HasDefaultValueSql("true");

            builder.HasOne(x => x.Customer).WithOne(x => x.Table).HasForeignKey<Table>(x => x.CustomerId);
        }
    }
}
