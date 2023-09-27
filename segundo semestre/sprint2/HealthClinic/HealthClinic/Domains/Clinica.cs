using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthClinic.Domains
{
   
        [Table("Clinica")]
        [Index(nameof(Cnpj), IsUnique = true)]
        public class Clinica
        {
            [Key]
            public Guid IdClinica { get; set; } = Guid.NewGuid();

            [Column(TypeName = "VARCHAR(14)")]
            [Required(ErrorMessage = "CNPJ Obrigatorio")]
            [StringLength(14)]
            public string? Cnpj { get; set; }

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "Endereco Obrigatorio")]
            public string? Endereco { get; set; }

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "Nome Fantasia Obrigatorio")]
            public string? NomeFantasia { get; set; }

            [Column(TypeName = "TEXT")]
            [Required(ErrorMessage = "Decricao  Obrigatoria")]
            public string? Descricao { get; set; }
        }
}