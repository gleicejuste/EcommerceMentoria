using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly ContextoPrincipal _dbContext;

        public ProdutoRepository(ContextoPrincipal dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AdicionarAsync(Produto entity)
        {
            throw new NotImplementedException();
        }

        public Task EditarAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(Produto idProduto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> PesquisarPorIdAsync(Guid idProduto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produto>> PesquisarTodosAsync()
        {
            return await _dbContext.Produtos.ToListAsync();
        }
    }
}
