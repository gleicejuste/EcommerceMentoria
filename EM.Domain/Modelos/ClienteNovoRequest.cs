using EM.Domain.Enums;
using System;
using System.Collections.Generic;

namespace EM.Domain.Modelos
{
    public class ClienteNovoRequest
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public string HashSenha { get; set; }

        public string Email { get; set; }

        public ICollection<TelefoneRequest> Telefones { get; set; }
    }

    public class TelefoneNovoRequest
    {
        public ETipoTelefone Tipo { get; set; }

        public string Numero { get; set; }
    }
}
