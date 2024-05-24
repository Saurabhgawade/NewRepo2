using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace entitycodefirstfinal.Models
{
    public class Register
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string Confirm_Password { get; set; }
    }
}
