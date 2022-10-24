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

        public async Task<IEnumerable<ClienteResponse>> PesquisarTodosAsync()
        {
            List<ClienteResponse> listaRetorno = new List<ClienteResponse>();
            IEnumerable<Cliente> listaClientes = await _repository.PesquisarTodosAsync();
            foreach(Cliente cliente in listaClientes)
            {
                listaRetorno.Add(_mapper.Map<ClienteResponse>(cliente));
            }
            return listaRetorno;
        }

        public async Task<ClienteResponse> PesquisarPorIdAsync(Guid id)
        {
            //Cliente cliente = await _repository.PesquisarPorIdAsync(id);
            // return _mapper.Map<ClienteResponse>(clinte);
            return _mapper.Map<ClienteResponse>(await _repository.PesquisarPorIdAsync(id));
        }

        public async Task<Cliente> PesquisarPorIdRetornoClienteAsync(Guid id)
        {
              return await _repository.PesquisarPorIdAsync(id);
        }

        public async Task<IEnumerable<ClienteResponse>> PesquisarComFiltrosAsync(
            string nome, string documento, string email)
        {

            List<ClienteResponse> listaRetorno = new List<ClienteResponse>();
            IEnumerable<Cliente> listaClientes = await _repository.PesquisarComFiltrosAsync(nome, documento, email);
            foreach (Cliente cliente in listaClientes)
            {
                listaRetorno.Add(_mapper.Map<ClienteResponse>(cliente));
            }
            return listaRetorno;
        }
        

        public async Task EditarAsync(ClienteRequest clienteRequest)
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
