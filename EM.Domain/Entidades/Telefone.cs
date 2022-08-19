using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EM.Domain.Entidades
{
    public class Telefone
    {
        [Key]
        private Guid Id { get; set; }

        [ForeignKey("ClienteId")]
        private Cliente Cliente { get; set; }

        private Guid ClienteId { get; set; }

        private int Tipo { get; set; }

        private string Numero { get; set; }

        [DataType(DataType.Date)]
        [Column("cadastrado_em")]
        private DateTime CadastradoEm { get; set; }
    }
}
