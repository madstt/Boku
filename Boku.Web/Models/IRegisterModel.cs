using System.ComponentModel.DataAnnotations;

namespace Boku.Models
{
    public interface IRegisterModel
    {
        [Required]
        [Display(Name = "Brugernavn:")]
        string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email adresse:")]
        string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekræft password:")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        string ConfirmPassword { get; set; }
    }
}