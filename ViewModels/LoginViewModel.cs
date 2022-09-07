
using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O Email é obrigatório")]
        public string EmailAddress  { get; set; }      

        [Display(Name = "Senha")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}