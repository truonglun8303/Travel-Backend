using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace do_an_Travel_Backend.Data
{
    public class TravelDbContextFactory : IDesignTimeDbContextFactory<TravelDbContext>
    {
        public TravelDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configurationRoot.GetConnectionString("TravelDatabase");
            var optionBuilder = new DbContextOptionsBuilder<TravelDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new TravelDbContext(optionBuilder.Options);
        }
    }
}
