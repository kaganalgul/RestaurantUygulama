using Microsoft.EntityFrameworkCore;
using RestaurantApi.Models.Entity;

namespace RestaurantApi.Models.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>().HasData(
                
                new Table()
                {
                    Id = 1
                }, 
                new Table()
                {
                    Id = 2
                }, 
                new Table()
                {
                    Id = 3
                }, 
                new Table()
                {
                    Id = 4
                },
                new Table()
                {
                    Id = 5
                },
                new Table()
                {
                    Id = 6
                },
                new Table()
                {
                    Id = 7
                },
                new Table()
                {
                    Id = 8
                },
                new Table()
                {
                    Id = 9
                },
                new Table()
                {
                    Id = 10
                }
            );
        }
    }
}
