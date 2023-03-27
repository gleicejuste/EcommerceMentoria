using EM.Domain.Entidades;
using EM.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EM.Service.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> PesquisarTodosAsync();
        Task AdicionarAsync(ProdutoNovoRequest produtoRequest);
        Task<Produto> PesquisarPorIdAsync(Guid idProduto);
       // Task<IEnumerable<ProdutoResponse>> PesquisarComFiltrosAsync(string nome, string documento, string email, string dataInicial, string dataFinal);
        Task EditarAsync(ProdutoRequest produtoRequest);
        Task ExcluirAsync(Guid idProduto);
        Task AtivarDesativarAsync(Guid id, bool ativo);
    }
}
