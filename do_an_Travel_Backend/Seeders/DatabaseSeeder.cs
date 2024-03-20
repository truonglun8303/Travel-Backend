using do_an_Travel_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace do_an_Travel_Backend.Seeders
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Travel>().HasData(
                new Travel() { Id = 1,Name = "Ahihi", IsComplete = false},
                new Travel() { Id = 2, Name = "Ahihi2", IsComplete = false }
            );
        }
    }
}
