using System.ComponentModel.DataAnnotations;

namespace WepApi.tarde.Domains
{
    /// <summary>
    /// representa a tabela  Filme
    /// </summary>
    public class FilmeDomain
    {
        public int? IdFilme { get; set; }
        [Required(ErrorMessage = "O titulo do filme e obrigatorio")]
        public string? Titulo { get; set; }

        public int? IdGenero { get; set; }

    //referencia para a classe genero
    public GeneroDomain Genero { get; set; }
}
}
