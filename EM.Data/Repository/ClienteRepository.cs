using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;
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
            return await _dbContext.Clientes.ToListAsync();
        }

        public async Task<Cliente> PesquisarPorIdAsync(Guid id)
        {
            return await _dbContext.Clientes.FindAsync(id);
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
