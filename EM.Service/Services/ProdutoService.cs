using AutoMapper;
using EM.Data.Repository;
using EM.Domain.Entidades;
using EM.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EM.Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _repository;

        public ProdutoService(IMapper mapper, IProdutoRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public Task AdicionarAsync(ProdutoNovoRequest produtoRequest)
        {
            throw new NotImplementedException();
        }

        public Task AtivarDesativarAsync(Guid id, bool ativo)
        {
            throw new NotImplementedException();
        }

        public Task EditarAsync(ProdutoRequest produtoRequest)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(Guid idProduto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> PesquisarPorIdAsync(Guid idProduto)
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<ProdutoResponse>> PesquisarTodosAsync()
        public async Task<IEnumerable<Produto>> PesquisarTodosAsync()
        {
            var produtosDb = await _repository.PesquisarTodosAsync();
            return produtosDb;
           // return _mapper.Map<IEnumerable<ProdutoResponse>>(produtosDb);
        }
    }
}
