using System;
using System.Collections.Generic;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Factory
{
    public static class ClienteFactory
    {
        public static Cliente CriarClienteSalvar(NovoClienteRequest clienteRequest)
        {
            var dataAgora = DateTime.Now;

            return new Cliente(
                clienteRequest.Nome,
                clienteRequest.Documento,
                clienteRequest.Email,
                clienteRequest.HashSenha,
                dataAgora,
                true,
                CriarTelefoneSalvar(clienteRequest.Telefones, dataAgora));
        }

        private static ICollection<Telefone> CriarTelefoneSalvar(ICollection<NovoTelefoneRequest> telefonesRequest, DateTime dataAgora)
        {
            var listaTelefones = new List<Telefone>();

            foreach (var telefoneRequest in telefonesRequest)
            {
                listaTelefones.Add(new Telefone(telefoneRequest.Tipo, telefoneRequest.Numero, dataAgora));
            }

            return listaTelefones;
        }

        //public static Cliente newCliente(ClienteId clienteId, NovoClienteRequest request)
        //{
        //    return new Cliente(
        //            clienteId,
        //            command.getNome(),
        //            command.getCpf(),
        //            command.getTelefones().stream()
        //                    .map(TelefoneFactory::criarTelefone)
        //                    .collect(Collectors.toList()));
        //}
    }
}
