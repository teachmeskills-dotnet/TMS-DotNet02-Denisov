using System.ComponentModel.DataAnnotations;

namespace Denisov.TobaccoStore.ViewModels
{
    /// <summary>
    /// Model which is used for Log in action.
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// User email.
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// User password.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Remember user or not.
        /// </summary>
        [Display(Name = "Remember?")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// Url used after successful log in action. 
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
