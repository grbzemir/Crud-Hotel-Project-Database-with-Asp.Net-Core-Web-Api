using HotelManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DataAccess
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext>options):base(options)
        {
            
        }

        public HotelDbContext()
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                string connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}