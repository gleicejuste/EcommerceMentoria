using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EM.Domain.Entidades
{
    public class Telefone
    {
        public Telefone(int tipo, string numero, DateTime dataCadastro)
        {
            Tipo = tipo;
            Numero = numero;
            DataCadastro = dataCadastro;
        }

        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public int Tipo { get; set; }

        public string Numero { get; set; }

        public DateTime DataCadastro { get; set; }

        public Cliente Cliente { get; set; }
    }
}
