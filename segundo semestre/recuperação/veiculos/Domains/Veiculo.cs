using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veiculos.Domains
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public Guid IdVeiculo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Modelo é obrigatório!")]
        public string? Modelo { get; set; }

        [Column(TypeName = "FLOAT")]
        [Required(ErrorMessage = "Preço é obrigatório!")]
        public float? Preco { get; set; }

        //propriedades da dependencia = entidade Fabricante

        [Required(ErrorMessage = "Fabricante é obrigatório!")]
        public Guid IdFabricante { get; set; }

        [ForeignKey(nameof(IdFabricante))]
        public Fabricante? Fabricante { get; set; }
    }
}
