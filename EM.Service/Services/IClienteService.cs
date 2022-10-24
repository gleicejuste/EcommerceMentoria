using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Services;

public interface IClienteService
{
    Task<IEnumerable<ClienteResponse>> PesquisarTodosAsync();
    Task AdicionarAsync(ClienteRequest request);
    Task<ClienteResponse> PesquisarPorIdAsync(Guid id);
    Task<Cliente> PesquisarPorIdRetornoClienteAsync(Guid id);
    Task<IEnumerable<ClienteResponse>> PesquisarComFiltrosAsync(string nome, string documento, string email);
    Task EditarAsync(ClienteRequest clienteRequest);
    Task ExcluirAsync(Cliente cliente);
    Task AtivarDesativarAsync(Guid id, bool ativoInativo);
}
