using EM.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EM.Data.Repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> PesquisarTodosAsync();
        Task AdicionarAsync(Produto entity);
        Task<Produto> PesquisarPorIdAsync(Guid idProduto);
      //  Task<IEnumerable<Produto>> PesquisarComFiltrosAsync(string nome, string documento, string email, string dataInicial, string dataFinal);
        Task EditarAsync(Produto produto);
        Task ExcluirAsync(Produto idProduto);
    }
}
