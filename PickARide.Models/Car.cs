namespace PickARide.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public string Registration { get; set; }

        public int Seats { get; set; }

        public bool HasAC { get; set; }

        public int DriverId { get; set; }

        public Driver Driver { get; set; }


    }
}