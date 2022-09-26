using EM.Data;
using EM.Data.Repository;
using EM.Domain.Entidades;
using EM.Domain.Modelos;
using EM.Service.Factory;

namespace EM.Service.Services
{
    public class ClienteService
    {

        readonly ContextoPrincipal _contextoPrincipal;
        readonly ClienteRepository _repository;

        public ClienteService(ContextoPrincipal contextoPrincipal)
        {
            _contextoPrincipal = contextoPrincipal;
            _repository = new ClienteRepository(_contextoPrincipal);
        }

        public void Add(NovoClienteRequest clienteRequest)
        {
            Cliente clienteSalvar = ClienteFactory.CriarClienteSalvar(clienteRequest);
            _repository.Add(clienteSalvar);
        }

        public IQueryable<Cliente> GetAll()
        {
            return _repository.GetAll();
        }

        public Cliente GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Put(Guid id, NovoClienteRequest clienteRequest)
        {
            Cliente cliente = _repository.GetById(id);
            if (cliente == null)
            {
                //return null;
            }

            //_mapper.Map(filmeDto, filme);
            Cliente clienteSalvar = ClienteFactory.CriarClienteSalvar(clienteRequest);
            _repository.Put(clienteSalvar);
        }
    }
}
