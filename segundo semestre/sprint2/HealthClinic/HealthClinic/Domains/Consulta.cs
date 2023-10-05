using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthClinic.Domains
{

    [Table("Consulta")]
    public class Consulta
    {
        //atributos da classe
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATETIME")]
        [Required(ErrorMessage = "Data e hora Obrigatorios")]
        public DateTime? Data { get; set; }

        //propriedades da dependencia = entidade Medico

        [Required(ErrorMessage = "Medico é obrigatório!")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }



        [Required(ErrorMessage = "Paciente é obrigatório!")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }

    }
}

