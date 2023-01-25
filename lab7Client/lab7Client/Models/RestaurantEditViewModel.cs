using System.ComponentModel.DataAnnotations;

namespace lab7Client.Models
{
    public class RestaurantEditViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Province")]
        public string ProvinceState { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z][ -]\d[A-Za-z]\d$", ErrorMessage = "Must be in the form of A1A 1A1")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Required]
        [Range(1, 5)]
        [Display(Name = "Rating (1 to 5)")]
        public decimal Rating { get; set; }
    }
}
