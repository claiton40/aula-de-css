using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthClinic.Domains
{
    
        [Table("Paciente")]
        [Index(nameof(Email), IsUnique = true)]
        public class Paciente
        {
            //propriedades da classe
            [Key]
           
            public Guid IdPaciente { get; set; } = Guid.NewGuid();

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "O Nome é obrigatório!")]
            public string? Nome { get; set; }

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "O Email do usuário é obrigatório!")]
            public string? Email { get; set; }

            [Column(TypeName = "VARCHAR(60)")]
            [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
            [StringLength(60, MinimumLength = 5, ErrorMessage = "A Senha deve contre entre 5 e 60 caracteres")]
            public string? Senha { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao da consulta e obrigatoria")]
        public string? Descricao { get; set; }

        //propriedades da dependencia = entidade Consulta
        
        public Guid IdConsulta { get; set; }
        //verificar com os professores onde que vai essa lista
        [ForeignKey(nameof(IdConsulta))]
        public List<Consulta> Consulta = new List<Consulta>();
    }

}

