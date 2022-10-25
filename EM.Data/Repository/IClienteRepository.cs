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
        Task<Cliente> PesquisarPorIdAsync(Guid idCliente);
        Task<IEnumerable<Cliente>> PesquisarComFiltrosAsync(string nome, string documento, string email, string dataInicial, string dataFinal);
        Task EditarAsync(Cliente cliente);
        Task ExcluirAsync(Cliente idCliente);
    }
}
