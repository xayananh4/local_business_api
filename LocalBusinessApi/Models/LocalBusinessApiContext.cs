using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Models
{
  public class LocalBusinessApiContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }

    public LocalBusinessApiContext(DbContextOptions<LocalBusinessApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Restaurant>()
        .HasData(
          new Restaurant { RestaurantId = 1, Name = "Blossoming Lotus" },
          new Restaurant { RestaurantId = 2, Name = "Native Bowl" },
          new Restaurant { RestaurantId = 3, Name = "Harlow" },
          new Restaurant { RestaurantId = 4, Name = "Hail Snail" },
          new Restaurant { RestaurantId = 5, Name = "Tiny Moreso" }
        );
    }
  }
}