using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Factory
{
    public class ClienteFactory
    {

        public static Cliente CriarClienteSalvar(NovoClienteRequest clienteRequest)
        {
            return new Cliente(
                clienteRequest.Nome,
                clienteRequest.Documento,
                clienteRequest.Email,
                clienteRequest.HashSenha,
                new DateTime(),
                true,
                CriarTelefoneSalvar(clienteRequest.Telefones));
        }

        private static ICollection<Telefone> CriarTelefoneSalvar(ICollection<NovoTelefoneRequest> telefonesRequest)
        {
            List<Telefone> listaTelefones = new List<Telefone>();

            foreach (var telefoneRequest in telefonesRequest)
            {
                listaTelefones.Add(new Telefone(telefoneRequest.Tipo, telefoneRequest.Numero, new DateTime()));
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
