using System.ComponentModel.DataAnnotations;

namespace Boku.DomainLogicLayer.AccountModels
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Brugernavn:")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Display(Name = "Husk mig?")]
        public bool RememberMe { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}