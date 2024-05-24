﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CookiPractise.Models
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}
