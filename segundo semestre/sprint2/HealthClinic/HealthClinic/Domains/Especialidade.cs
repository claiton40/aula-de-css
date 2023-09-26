using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthClinic.Domains
{
    [Table("Especialidade")]
    public class Especialidade
    {
        //propriedades da classe
        [Key]
        public Guid IdEspecialidade { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome da Especialidade é obrigatório!")]
        public string? Nome { get; set; }
    }
}
