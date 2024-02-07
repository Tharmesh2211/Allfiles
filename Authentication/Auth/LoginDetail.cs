﻿using System.ComponentModel.DataAnnotations;

namespace Authentication.Auth
{
    public class LoginDetail
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
