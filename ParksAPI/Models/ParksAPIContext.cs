using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
    public class ParksAPIContext : DbContext
    {
        public ParksAPIContext(DbContextOptions<ParksAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
            .HasData(
              new Park { ParkId = 1, ParkName = "Bullards Beach", Type = "State", City = "Coos Bay", State = "Oregon", Feature = "yurts"},
              new Park { ParkId = 2, ParkName = "Cottonwood Canyon", Type = "State", City = "The Dalles", State = "Oregon", Feature = "fishing"},
              new Park { ParkId = 3, ParkName = "Fort Stevens State Park", Type = "State", City = "Astoria", State = "Oregon", Feature = "swimming"},
              new Park { ParkId = 4, ParkName = "Crater Lake", Type = "National", City = "Crater Lake", State = "Oregon", Feature = "biking"}
            );

        }
    }
}
