using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace entitycodefirstfinal.Models
{
    public class Signin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string  PassWord { get; set; }

        [Required]
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}
