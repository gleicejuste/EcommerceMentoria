using EM.Domain.Enums;
using System.Collections.Generic;

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

        public TelefoneEnum Tipo { get; set; }

        public string Numero { get; set; }

    }
}
