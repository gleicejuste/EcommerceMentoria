using System;
using System.Collections.Generic;
using EM.Domain.Enums;

namespace EM.Domain.Modelos
{
    public class ClienteResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Email { get; set; }

        public IEnumerable<TelefoneResponse> Telefones { get; set; }
    }

    public class TelefoneResponse
    {
        public ETipoTelefone Tipo { get; set; }

        public string Numero { get; set; }
    }

}
