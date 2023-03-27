using System;

namespace EM.Domain.Entidades
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Sku { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Estoque { get; set; }
        public bool Ativo { get; set; }

        public Produto() { }

        public Produto(
            string nome,
            string descricao,
            string sku,
            DateTime dataCadastro,
            int estoque,
            bool ativo)

        {
            Nome = nome;
            Descricao = descricao;
            Sku = sku;
            DataCadastro = dataCadastro;
            Estoque = estoque;
            Ativo = ativo;
        }

    }
}
