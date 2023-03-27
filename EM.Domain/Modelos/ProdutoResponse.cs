using System;

namespace EM.Domain.Modelos
{
    public class ProdutoResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Sku { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Estoque { get; set; }
        public bool Ativo { get; set; }
    }
}
