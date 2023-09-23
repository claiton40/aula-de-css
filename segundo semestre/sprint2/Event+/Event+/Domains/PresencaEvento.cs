using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domains
{
    [Table("PresencaEvento")]
    public class PresencaEvento
    {
        //atributos da classe
        [Key]
        public Guid IdPresencaEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Situação Obrigatoria")]
        public bool Situacao { get; set; }

        //atributos das dependencias = Usuario

        [Required(ErrorMessage = "Usuario obrigatorio")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        //atributos das dependencias = Evento

        [Required(ErrorMessage = "Evento Obrigatorio")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]
        public Evento? Eventos { get; set; }
    }
}