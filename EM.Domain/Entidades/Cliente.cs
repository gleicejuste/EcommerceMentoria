using System;
using System.Collections.Generic;

namespace EM.Domain.Entidades
{
    public class Cliente
    {
        public Cliente(
            string nome,
            string documento,
            string email,
            string hashSenha,
            DateTime dataCadastro,
            bool ativo,
            ICollection<Telefone> telefones)

        {
            Nome = nome;
            Documento = documento;
            Email = email;
            HashSenha = hashSenha;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            Telefones = telefones;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Email { get; set; }

        public string HashSenha { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public ICollection<Telefone> Telefones { get; set; }
    }

}
