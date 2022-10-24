using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EM.Domain.Entidades;
using EM.Domain.Modelos;
using Microsoft.EntityFrameworkCore;

namespace EM.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ContextoPrincipal _dbContext;

        public ClienteRepository(ContextoPrincipal dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AdicionarAsync(Cliente cliente)
        {
            _dbContext.Add(cliente);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cliente>> PesquisarTodosAsync()
        {
            return await _dbContext.Clientes.Include(c => c.Telefones).ToListAsync();
        }

        public async Task<Cliente> PesquisarPorIdAsync(Guid id)
        {
            //.AsNoTracking tirar rastreio da entidade:
            //se usa em casos que não será necessário manipular os dados da entidade
            return await _dbContext.Clientes
                .Include(c => c.Telefones)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Cliente>> PesquisarComFiltrosAsync(string nome, string documento, string email)
        {
            var queryable = _dbContext.Clientes
                .AsNoTracking()
                .Include(c => c.Telefones)
                .OrderBy(c => c.Nome)
                .ThenBy(c => c.Email)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                // WHERE [Cliente] LIKE '%FILTRO%'
                // queryable = queryable.Where(c => EF.Functions.Like(c.Nome, $"%{nome}%"));

                // WHERE [Cliente] LIKE 'FILTRO'
                // queryable = queryable.Where(c => c.Nome.Contains(nome));

                // WHERE [Cliente] = 'FILTRO'
                // queryable = queryable.Where(c => c.Nome.ToLower() == nome.ToLower());
                queryable = queryable.Where(c => c.Nome.Equals(nome));
            }

            // IsNullOrWhiteSpace verifica se é nulo, se é vazio ou se contém espaços vazios '   '
            if (!string.IsNullOrWhiteSpace(documento))
                queryable = queryable.Where(c => c.Documento.Equals(documento));

            if (!string.IsNullOrWhiteSpace(email))
                queryable = queryable.Where(c => c.Email.Equals(email));

            return await queryable.ToListAsync();
        }

        public async Task EditarAsync(Cliente clienteSalvar)
        {
            _dbContext.Update(clienteSalvar);
            await _dbContext.SaveChangesAsync();
        }

        public async Task ExcluirAsync(Cliente id)
        {
            _dbContext.Remove(id);
            await _dbContext.SaveChangesAsync();
        }
    }
}
