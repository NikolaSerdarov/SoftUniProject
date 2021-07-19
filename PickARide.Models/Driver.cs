using System.Collections.Generic;

namespace PickARide.Models
{
    public class Driver
    {
        public Driver()
        {
            this.Trips = new HashSet<Trip>();
            this.Clients = new HashSet<Client>();
        }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
        public string DrivingLicenseNumber { get; set; }


        public Location HomeAddress { get; set; }

        public Location CurrentLocation { get; set; }


        public bool IsAvailable { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public int CurrentClientId { get; set; }
        public Client CurrentClient { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Trip> Trips{ get; set; }
    }
}