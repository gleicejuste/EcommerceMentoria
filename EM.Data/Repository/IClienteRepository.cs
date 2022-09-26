using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;

namespace EM.Data.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task AddAsync(Cliente entity);
        Task<Cliente> GetByIdAsync(Guid id);
        Task EditAsync(Cliente clienteSalvar);
    }
}
