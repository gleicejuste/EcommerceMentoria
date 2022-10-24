using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Data.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> PesquisarTodosAsync();
        Task AdicionarAsync(Cliente entity);
        Task<Cliente> PesquisarPorIdAsync(Guid id);
        Task<IEnumerable<Cliente>> PesquisarComFiltrosAsync(string nome, string documento, string email);
        Task EditarAsync(Cliente clienteSalvar);
        Task ExcluirAsync(Cliente id);
    }
}
