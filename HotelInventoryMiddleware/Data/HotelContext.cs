using Microsoft.EntityFrameworkCore;
using HotelInventoryMiddleware.Models;

namespace HotelInventoryMiddleware.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

        public DbSet<Hotel> Hotels => Set<Hotel>();
        public DbSet<Room> Rooms => Set<Room>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
