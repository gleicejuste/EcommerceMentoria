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
            //síncrono
            return _dbContext.Clientes
                .Where(c => c.Nome.Equals(nome) && c.Documento.Equals(documento) && c.Email.Equals(email))
                .Include(c => c.Telefones)
                .AsNoTracking();

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
