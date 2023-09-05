using System.ComponentModel.DataAnnotations;

namespace inlock_games.Domains
{
    public class UsuariosDomain
    {
        public int IdUsuario { get; set; }

        public int IdTipoUsuario { get;set;}

        [Required(ErrorMessage = "O E-mail é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório!")]
        public string Senha { get; set; }

        public TiposUsuariosDomain Usuario { get; set; }
    }
}
