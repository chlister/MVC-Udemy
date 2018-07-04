using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Driving Licens")]
        public string DrivingLicens { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
