using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Services;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> GetAllAsync();
    Task AddAsync(NovoClienteRequest request);
    Task<Cliente> GetByIdAsync(Guid id);
}
