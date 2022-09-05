using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EM.Domain.Entidades
{
    public class Telefone
    {
        public Guid Id { get; set; }
        public Cliente Cliente { get; set; }

        public int Tipo { get; set; }

        public string Numero { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
