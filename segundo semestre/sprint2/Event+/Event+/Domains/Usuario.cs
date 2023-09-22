using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domains
{
    [Table("Usuario")]
    public class Usuario
    {
        //propriedades da classe
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome Obrigatoria")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "E-Mail Obrigatoria")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "Senha Obrigatoria")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "A Senha deve contre entre 5 e 60 caracteres")]
        public string? Senha { get; set; }

        //propriedades da dependencia

        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TipoEvento? TipoEvento { get; set; }
    }
}
