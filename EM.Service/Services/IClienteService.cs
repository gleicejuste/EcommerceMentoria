using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Services;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> PesquisarTodosAsync();
    Task AdicionarAsync(NovoClienteRequest request);
    Task<Cliente> PesquisarPorIdAsync(Guid id);
    Task Editar(Guid id, NovoClienteRequest clienteRequest);
    Task Excluir(Guid id);
}
