﻿using System.ComponentModel.DataAnnotations;

namespace ITSS.Models
{
    public class PasswordResetDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required, EmailAddress]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "The Confirm Password field is required")]
        [Compare("Password", ErrorMessage = "Confirm Password and Password do not match")]
        public string ConfirmPassword { get; set; } = "";
    }
}