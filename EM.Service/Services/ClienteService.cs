using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Data.Repository;
using EM.Domain.Entidades;
using EM.Domain.Modelos;
using EM.Service.Factory;

namespace EM.Service.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task AdicionarAsync(NovoClienteRequest request)
        {
            Cliente clienteSalvar = ClienteFactory.CriarClienteSalvar(request);
            await _repository.AdicionarAsync(clienteSalvar);
        }

        public async Task<IEnumerable<Cliente>> PesquisarTodosAsync()
        {
            return await _repository.PesquisarTodosAsync();
        }

        public async Task<Cliente> PesquisarPorIdAsync(Guid id)
        {
            return await _repository.PesquisarPorIdAsync(id);
        }

        public async Task Editar(Guid id, NovoClienteRequest clienteRequest)
        {
            Cliente cliente = await _repository.PesquisarPorIdAsync(id);
            if (cliente == null)
             {
                 throw new DllNotFoundException();
             }

             Cliente clienteSalvar = ClienteFactory.CriarClienteSalvar(clienteRequest);
             await _repository.EditarAsync(clienteSalvar);
         }

        public async Task Excluir(Guid id)
        {
            await _repository.ExcluirAsync(id);
        }
    }
}
