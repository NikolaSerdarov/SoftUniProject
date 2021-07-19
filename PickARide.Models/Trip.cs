using System;
using System.Collections.Generic;

namespace PickARide.Models
{
    public class Trip
    {
        public int Id { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }
        public int NumberOfStops { get; set; }

        public Location PickUp { get; set; }

        public  ICollection<Location> Destionations { get; set; }

        public double Lenght { get; set; }

        public DateTime TripStart { get; set; }
        public DateTime TripEnd { get; set; }

        

    }
}