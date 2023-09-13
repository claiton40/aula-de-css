using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inlock2.Domains
{
    [Table("Estudio")]
    public class Estudio
    {
        [Key]
        public Guid IdEstudio { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage ="Nome Obrigatorio")]
        [Column(TypeName = "varchar(100)")]
        public string Nome { get; set; }
        public List<Jogo> Jogo { get;}



    }

}
