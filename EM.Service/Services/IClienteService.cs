using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Services;

public interface IClienteService
{
    Task<IEnumerable<ClienteResponse>> PesquisarTodosAsync();
    Task AdicionarAsync(ClienteNovoRequest clienteRequest);
    Task<ClienteResponse> PesquisarPorIdAsync(Guid idCliente);
    Task<IEnumerable<ClienteResponse>> PesquisarComFiltrosAsync(string nome, string documento, string email, string dataInicial, string dataFinal);
    Task EditarAsync(ClienteRequest clienteRequest);
    Task ExcluirAsync(Guid idCliente);
    Task AtivarDesativarAsync(Guid id, bool ativo);
}
