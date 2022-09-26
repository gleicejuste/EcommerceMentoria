
using EM.Domain.Entidades;

namespace EM.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        readonly ContextoPrincipal _contextoPrincipal;

        public ClienteRepository(ContextoPrincipal contextoPrincipal)
        {
            _contextoPrincipal = contextoPrincipal;
        }

        public void Add(Cliente clienteSalvar)
        {
            _contextoPrincipal.Add(clienteSalvar);
            _contextoPrincipal.SaveChanges();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _contextoPrincipal.Clientes;
        }

        public Cliente GetById(Guid id)
        {
            return _contextoPrincipal.Clientes.FirstOrDefault(cliente => cliente.Id.Equals(id));
        }

        public void Editar(Cliente clienteSalvar)
        {
            _contextoPrincipal.Update(clienteSalvar);
            _contextoPrincipal.SaveChanges();
        }
    }
}
