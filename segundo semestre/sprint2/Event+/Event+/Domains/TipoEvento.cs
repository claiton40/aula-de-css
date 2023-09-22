using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domains
{
    [Table("TipoEvento")]
    public class TipoEvento
    {
        [Key]
        public Guid IdTipoDeEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Titulo e obrigatorio")]
        public string Titulo { get; set; }
    }
}
