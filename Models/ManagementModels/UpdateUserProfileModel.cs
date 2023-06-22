using System.ComponentModel.DataAnnotations;

namespace API_Authentication.Models.ManagementModels
{
    public class UpdateUserProfileModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 2)]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "O campo {0} deve ser um endereço de email válido.")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
