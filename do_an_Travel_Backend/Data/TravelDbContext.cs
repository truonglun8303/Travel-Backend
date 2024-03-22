
using do_an_Travel_Backend.Configuration;
using do_an_Travel_Backend.Controllers;
using do_an_Travel_Backend.Models;
using do_an_Travel_Backend.Models.EF;
using do_an_Travel_Backend.Seeders;
using Microsoft.EntityFrameworkCore;
namespace do_an_Travel_Backend.Data
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TravelConfiguration());

            modelBuilder.Seed();

            
        }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }  
        public DbSet<Destination> Destination { get; set; }
        public DbSet<DestinationImage> DestinationImage { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tour> Tours { get; set; }
    }
}
