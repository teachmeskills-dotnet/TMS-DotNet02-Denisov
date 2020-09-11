using System;
using System.ComponentModel.DataAnnotations;

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

        /// <summary>
        /// Registration first name.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Registration second name.
        /// </summary>
        [Required]
        public string SecondName { get; set; }

        /// <summary>
        /// Registration middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Registration birth date.
        /// </summary>
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
