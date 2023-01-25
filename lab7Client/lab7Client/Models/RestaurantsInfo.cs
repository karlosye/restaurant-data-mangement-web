using System.Runtime.Serialization;

namespace lab7Client.Models
{
    public class RestaurantsInfo
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Summary { get; set; }
        public decimal? Rating { get; set; }

        public AddressInfo? Location { get ; set; }

        public string? FoodType { get; set; }

        public string? Cost { get; set; }
    }
}
