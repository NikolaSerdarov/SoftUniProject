using Microsoft.EntityFrameworkCore;
using PickARide.Models;
using System;

namespace PickARide.Data
{
    public class PickARideContext : DbContext
    {
        public PickARideContext()
        {
        }

        public PickARideContext(DbContextOptions<PickARideContext> options)
            : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<Location> Locations { get; set; }
    }
}
