using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;

namespace EM.Data.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> PesquisarTodosAsync();
        Task AdicionarAsync(Cliente entity);
        Task<Cliente> PesquisarPorIdAsync(Guid id);
        Task EditarAsync(Cliente clienteSalvar);
        Task ExcluirAsync(Guid id);
    }
}
