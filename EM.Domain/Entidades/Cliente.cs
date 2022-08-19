
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EM.Domain.Entidades
{
    public class Cliente
    {
        [Key]
        private Guid Id { get; set; }

        private String Nome { get; set; }

        private String Documento { get; set; }

        [Index(IsUnique = true)]
        private String Email { get; set; }

        [Column("hash_senha")]
        private String HashSenha { get; set; }

        [DataType(DataType.Date)]
        [Column("cadastrado_em")]
        private DateTime CadastradoEm { get; set; }

        private bool Ativo { get; set; }
    }
}
