using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EM.Data.Repository;
using EM.Domain.Entidades;
using EM.Domain.Modelos;
using EM.Service.Factory;

namespace EM.Service.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(NovoClienteRequest request)
        {
            Cliente clienteSalvar = ClienteFactory.CriarClienteSalvar(request);
            await _repository.AddAsync(clienteSalvar);
        }

        public Task<IEnumerable<Cliente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        // public IQueryable<Cliente> GetAll()
        // {
        //     return _repository.GetAllAsync();
        // }

        // public Cliente GetById(Guid id)
        // {
        //     return _repository.GetById(id);
        // }

        // public void Put(Guid id, NovoClienteRequest clienteRequest)
        // {
        //     Cliente cliente = _repository.GetById(id);
        //     if (cliente == null)
        //     {
        //         //return null;
        //     }

        //     //_mapper.Map(filmeDto, filme);
        //     Cliente clienteSalvar = ClienteFactory.CriarClienteSalvar(clienteRequest);
        //     //  _repository.Put(clienteSalvar);
        // }
    }
}
