using System;
using System.Collections.Generic;
using System.Linq;
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
            var clientesDb = await _repository.PesquisarTodosAsync();
            return _mapper.Map<IEnumerable<ClienteResponse>>(clientesDb);
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
            var clientesDb = await _repository.PesquisarComFiltrosAsync(nome, documento, email);
            if (clientesDb == null || !clientesDb.Any())
                return Enumerable.Empty<ClienteResponse>();

            // Manipulando lista
            var listaFiltrada = clientesDb.Where(c => c.Ativo).ToList();

            // foreach (var cliente in listaFiltrada)
            // {
            //     cliente.DataCadastro = DateTime.Now;
            // }
            // listaFiltrada.Add(new Cliente());

            return _mapper.Map<IEnumerable<ClienteResponse>>(listaFiltrada);
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
