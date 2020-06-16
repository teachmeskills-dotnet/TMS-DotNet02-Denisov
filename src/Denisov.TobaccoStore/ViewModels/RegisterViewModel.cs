﻿using System.ComponentModel.DataAnnotations;

namespace Denisov.TobaccoStore.ViewModels
{
    /// <summary>
    /// Model which is used for registration action.
    /// </summary>
    public class RegisterViewModel
    {
        /// <summary>
        /// Registration email.
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Registration password.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Passwords match.
        /// </summary>
        [Required]
        [Compare("Password", ErrorMessage = "Passwords not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Password confirm")]
        public string PasswordConfirm { get; set; }
    }
}
