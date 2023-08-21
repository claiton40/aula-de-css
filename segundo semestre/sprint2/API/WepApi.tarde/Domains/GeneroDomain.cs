using System.ComponentModel.DataAnnotations;

namespace WepApi.tarde.Domains
{
    /// <summary>
    /// Entidade que representa a tabela Genero
    /// </summary>
    public class GeneroDomain
    {
        public int IdGenero { get; set; }
        [Required(ErrorMessage ="O Genero e Obrigatorio")]
        public string? Nome { get; set; }
    }
}
