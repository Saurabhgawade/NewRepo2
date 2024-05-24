using System.ComponentModel.DataAnnotations;

namespace cookieauthentication.Models
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
        [Display(Name ="Confirm Password")]
        public string Confirm_Password { get; set; }
    }
}
