using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EM.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ContextoPrincipal _contextoPrincipal;

        public ClienteRepository(ContextoPrincipal contextoPrincipal)
        {
            _contextoPrincipal = contextoPrincipal;
        }

        public async Task AddAsync(Cliente clienteSalvar)
        {
            _contextoPrincipal.Add(clienteSalvar);
            await _contextoPrincipal.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _contextoPrincipal.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetByIdAsync(Guid id)
        {
            return await _contextoPrincipal.Clientes.FindAsync(id);
        }

        public async Task EditAsync(Cliente clienteSalvar)
        {
            _contextoPrincipal.Update(clienteSalvar);
            await _contextoPrincipal.SaveChangesAsync();
        }
    }
}
