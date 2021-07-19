using System.Collections.Generic;

namespace PickARide.Models
{
    public class Location
    {
        public Location()
        {
            this.Clients = new HashSet<Client>();
            this.Drivers = new HashSet<Driver>();
        }
        public int Id { get; set; }

        public string District { get; set; }

        public string StreetName { get; set; }

        public int StreetNumber { get; set; }

        public ICollection<Client> Clients { get; set; }

        public ICollection<Driver> Drivers { get; set; }
    }
}