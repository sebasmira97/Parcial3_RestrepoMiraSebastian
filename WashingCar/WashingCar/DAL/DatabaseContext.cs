using Microsoft.EntityFrameworkCore;
using WashingCar.DAL.Entities;

namespace WashingCar.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDetail> vehicleDetails { get; set; }
    }
}

