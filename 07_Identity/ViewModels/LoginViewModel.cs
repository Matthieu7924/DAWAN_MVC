using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _07_Identity.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = String.Empty;

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }    
    }
}
