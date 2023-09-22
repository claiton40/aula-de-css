using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domains
{
    [Table("Evento")]
    public class Evento
    {
        //atributos da classe
        [Key]
        public Guid IdEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage ="Data Obrigatoria")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome Obrigatoria")]
        public string NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao Obrigatoria")]
        public string Descricao { get; set; }
        
        //atributos das dependencias = Tipo de Evento
        public Guid IdTipoDeEvento { get; set; }

        [ForeignKey(nameof(IdTipoDeEvento))]
        public TipoEvento TipoEvento { get; set; }

        //atributos das dependencias = Instituicao
        public Guid IdInstituicao { get; set; }

        [ForeignKey(nameof(IdInstituicao))]
        public Instituicao Instituicao { get; set; }

    }
}
