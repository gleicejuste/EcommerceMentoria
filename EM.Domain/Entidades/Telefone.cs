using System;
using EM.Domain.Enums;

namespace EM.Domain.Entidades
{
    public class Telefone
    {
        public Telefone()
        {
        }

        public Telefone(ETipoTelefone tipo, string numero, DateTime dataCadastro)
        {
            Tipo = tipo;
            Numero = numero;
            DataCadastro = dataCadastro;
        }

        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public ETipoTelefone Tipo { get; set; }

        public string Numero { get; set; }

        public DateTime DataCadastro { get; set; }

        public Cliente Cliente { get; set; }
    }
}
