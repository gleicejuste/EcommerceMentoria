﻿using System;
using System.Collections.Generic;
using EM.Domain.Enums;

namespace EM.Domain.Modelos
{
    public class ClienteRequest
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Email { get; set; }

        public ICollection<TelefoneRequest> Telefones { get; set; }
    }

    public class TelefoneRequest
    {
        public ETipoTelefone Tipo { get; set; }

        public string Numero { get; set; }
    }
}
