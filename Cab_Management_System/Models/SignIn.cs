using System.ComponentModel.DataAnnotations;

namespace Cab_Management_System.Models
{
    public class SignIn
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        
        public string Password { get; set; }
    }
}
