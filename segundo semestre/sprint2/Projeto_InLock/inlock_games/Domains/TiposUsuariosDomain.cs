using System.ComponentModel.DataAnnotations;

namespace inlock_games.Domains
{
    public class TiposUsuariosDomain
    {
        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O titulo é obrigatório!")]
        public string Titulo { get; set;}
    }
}
