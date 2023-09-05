using System.ComponentModel.DataAnnotations;

namespace inlock_games.Domains
{
    public class EstudiosDomain
    {
        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "O nome do Estudio é obrigatório!")]
        public string Nome { get; set; }
    }
}
