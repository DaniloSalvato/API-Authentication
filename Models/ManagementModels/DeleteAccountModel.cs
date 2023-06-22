using System.ComponentModel.DataAnnotations;

namespace API_Authentication.Models.ManagementModels
{
    public class DeleteAccountModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Password { get; set; }
    }
}
