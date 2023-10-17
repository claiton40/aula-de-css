using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veiculos.Domains
{
    [Table("Fabricante")]
    public class Fabricante
    {
        [Key]
        public Guid IdFabricante { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome é obrigatório!")]
        public string? Nome { get; set; }
    }
}
