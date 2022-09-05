using System.ComponentModel.DataAnnotations.Schema;

namespace EM.Domain.Entidades
{
    public class Cliente
    {
    
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public String Documento { get; set; }

        public String Email { get; set; }

        public String HashSenha { get; set; }

        public DateTime CadastradoEm { get; set; }

        public bool Ativo { get; set; }
    }
}
