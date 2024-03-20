
using do_an_Travel_Backend.Configuration;
using do_an_Travel_Backend.Controllers;
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
    }
}
