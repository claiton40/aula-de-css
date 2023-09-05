using System.ComponentModel.DataAnnotations;

namespace inlock_games.Domains
{
    public class JogosDomain
    {
        public int IdJogo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descricao é obrigatória!")]
        public string Descricao { get; set;}

        [Required(ErrorMessage = "A data de lancamento é obrigatória!")]
        public DateTime DataLancamento { get; set;}

        [Required(ErrorMessage = "O Preco é obrigatório!")]
        public float Valor { get; set; }
        public int IdEstudio { get; set; }
        public EstudiosDomain Estudio { get; set; }
    }
}
