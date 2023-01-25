using System.ComponentModel.DataAnnotations;

namespace lab7Client.Models
{
    public class RestaurantCreateViewModel
    {

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Street Address")]
        public string? StreetAddress { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "Province")]
        public string? ProvinceState { get; set; }

        [Display(Name = "PostalCode")]
        public string? PostalCode { get; set; }

        [Display(Name = "Summary")]
        public string? Summary { get; set; }

        [Display(Name = "Food Type")]
        public string? FoodType { get; set; }

        [Display(Name = "Rating (best=5)")]
        public decimal? Rating { get; set; }

        [Display(Name = "Cost (most expensive=5)")]
        public decimal? Cost { get; set; }

    }
}
