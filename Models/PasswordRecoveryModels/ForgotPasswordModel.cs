using System.ComponentModel.DataAnnotations;

namespace API_Authentication.Models.PasswordRecovery
{
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo {0} deve ser um endereço de email válido.")]
        public string Email { get; set; }
    }
}
