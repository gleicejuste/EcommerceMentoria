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

        public async Task AdicionarAsync(ClienteNovoRequest clienteRequest)
        {
            var cliente = _mapper.Map<Cliente>(clienteRequest);
            await _repository.AdicionarAsync(cliente);
        }

        public async Task<IEnumerable<ClienteResponse>> PesquisarTodosAsync()
        {
            var clientesDb = await _repository.PesquisarTodosAsync();
            return _mapper.Map<IEnumerable<ClienteResponse>>(clientesDb);
        }

        public async Task<Cliente> PesquisarPorIdAsync(Guid idCliente)
        {
            //Cliente cliente = await _repository.PesquisarPorIdAsync(idCliente);
            // return _mapper.Map<ClienteResponse>(clinte);
            //return _mapper.Map<ClienteResponse>(await _repository.PesquisarPorIdAsync(idCliente));
            return await _repository.PesquisarPorIdAsync(idCliente);
        }

        public async Task<IEnumerable<ClienteResponse>> PesquisarComFiltrosAsync(
            string nome, string documento, string email, string dataInicial, string dataFinal)
        {
            var clientesDb = await _repository.PesquisarComFiltrosAsync(nome, documento, email, dataInicial, dataFinal);
            if (clientesDb == null || !clientesDb.Any())
                return Enumerable.Empty<ClienteResponse>();

            // Manipulando lista
            var listaFiltrada = clientesDb.Where(c => c.Ativo).ToList();
            return _mapper.Map<IEnumerable<ClienteResponse>>(listaFiltrada);
        }

        public async Task EditarAsync(ClienteRequest clienteRequest)
        {
            //editar
            //busca por id
            //faz o mapper
            //perde os campos que nao editam
            var cliente = _mapper.Map<Cliente>(clienteRequest);
            await _repository.EditarAsync(cliente);
        }

        public async Task ExcluirAsync(Guid idCliente)
        {
            Cliente cliente = await _repository.PesquisarPorIdAsync(idCliente);
            if (cliente != null)
            {
                await _repository.ExcluirAsync(cliente);
            }
        }

        public async Task AtivarDesativarAsync(Guid idCliente, bool ativo)
        {
            Cliente cliente = await _repository.PesquisarPorIdAsync(idCliente);
            if (cliente != null)
            {
                cliente.Ativo = ativo;
                await _repository.EditarAsync(cliente);
            }
        }
    }
}
