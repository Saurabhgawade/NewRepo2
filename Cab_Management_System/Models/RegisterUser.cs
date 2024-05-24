using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cab_Management_System.Models
{
    public class RegisterUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]

        [DataType(DataType.Password)]
        public  string Password { get; set; }

        [Required]

        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string Confirm_Password { get; set; }
    }
}
