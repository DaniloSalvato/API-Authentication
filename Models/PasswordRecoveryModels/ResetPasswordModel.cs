using System.ComponentModel.DataAnnotations;

namespace API_Authentication.Models.PasswordRecovery
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Token { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "A nova senha e a confirmação da senha não coincidem.")]
        public string ConfirmNewPassword { get; set; }
    }
}
