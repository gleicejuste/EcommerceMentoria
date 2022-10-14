using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Services;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> PesquisarTodosAsync();
    Task AdicionarAsync(ClienteRequest request);
    Task<Cliente> PesquisarPorIdAsync(Guid id);
    Task EditarAsync(Guid id, ClienteRequest clienteRequest);
    Task ExcluirAsync(Cliente id);
    Task AtivarDesativarAsync(Guid id, bool ativoInativo);
}
