using System.Collections.Generic;
using EM.Domain.Enums;

namespace EM.Domain.Modelos
{
    public class NovoClienteRequest
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Email { get; set; }

        public string HashSenha { get; set; }

        public ICollection<NovoTelefoneRequest> Telefones { get; set; }
    }

    public class NovoTelefoneRequest
    {
        public ETelefone Tipo { get; set; }

        public string Numero { get; set; }
    }
}
