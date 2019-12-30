using System.ComponentModel.DataAnnotations;

namespace TD.Dominio.ViewModel
{
    public class Login
    {
        [Required(ErrorMessage = "O campo senha é de preenchimento obrigatório")]
        public string Usuario { get; set; }
        [Required(ErrorMessage ="O campo senha é de preenchimento obrigatório")]
        public string Senha { get; set; }

    }
}
