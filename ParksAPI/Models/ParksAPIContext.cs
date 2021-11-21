using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
    public class ParksAPIContext : DbContext
    {
      public ParksAPIContext(DbContextOptions<ParksAPIContext> options) : base(options) { }
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Park>()
          .HasData(
            new Park{ ParkId = 1, Name = "Crater Lake National Park", Location = "Oregon", National = true, State = false},
            new Park{ ParkId = 2, Name = "Glacier National Park", Location = "Montana", National = true, State = false},
            new Park{ ParkId = 3, Name = "Rasar State Park", Location = "Washington", National = false, State = true},
            new Park{ ParkId = 4, Name = "Silver Falls State Park", Location = "Oregon", National = false, State = true}
          );
      }
      public DbSet<Park> Parks { get; set; }
    }
}