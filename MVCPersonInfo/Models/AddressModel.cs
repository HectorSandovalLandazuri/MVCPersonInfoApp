using System.ComponentModel.DataAnnotations;

namespace MVCPersonInfo.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name ="Street Address")]
        public string StreetAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "State")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Postal Code")]
        [StringLength(10,MinimumLength =5)]
        public string PostalCode { get; set; }
    }
}
