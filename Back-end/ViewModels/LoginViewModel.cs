using System.ComponentModel.DataAnnotations;

namespace GUFOS_BackEnd.ViewModels {
    public class LoginViewModel {

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Senha  { get; set; }

    }
}