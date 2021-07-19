using System;
using System.Collections.Generic;

namespace PickARide.Models
{
    public class Client
    {
        public Client()
        {
            this.Trips = new HashSet<Trip>();
        }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public Location HomeAddress { get; set; }

        public Location WorkAddress { get; set; }
        public Location CurrentAddress { get; set; }

        public decimal Bill { get; set; }

        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        public ICollection<Trip> Trips { get; set; }
        public ICollection<Review> Reviews { get; set; }


    }

}
