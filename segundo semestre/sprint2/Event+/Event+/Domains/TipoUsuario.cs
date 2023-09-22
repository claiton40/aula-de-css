using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domains
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        //propriedades da classe
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome Obrigatoria")]
        public string Titulo { get; set; }
    }
}
