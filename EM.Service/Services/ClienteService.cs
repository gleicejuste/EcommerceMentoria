using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EM.Data.Repository;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _repository;

        public ClienteService(IMapper mapper, IClienteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task AdicionarAsync(ClienteRequest clienteRequest)
        {
            var cliente = _mapper.Map<Cliente>(clienteRequest);
            await _repository.AdicionarAsync(cliente);
        }

        public async Task<IEnumerable<Cliente>> PesquisarTodosAsync()
        {
            return await _repository.PesquisarTodosAsync();
        }

        public async Task<Cliente> PesquisarPorIdAsync(Guid id)
        {
            return await _repository.PesquisarPorIdAsync(id);
        }

        public async Task EditarAsync(Guid id, ClienteRequest clienteRequest)
        {
            var cliente = _mapper.Map<Cliente>(clienteRequest);
            await _repository.EditarAsync(cliente);
        }

        public async Task ExcluirAsync(Cliente id)
        {
            await _repository.ExcluirAsync(id);
        }

        public async Task AtivarDesativarAsync(Guid id, bool ativoInativo)
        {
            Cliente cliente = await _repository.PesquisarPorIdAsync(id);
            if (cliente != null)
            {
                cliente.Ativo = ativoInativo;
                await _repository.EditarAsync(cliente);
            }
        }
        
    }
}
