
using EM.Domain.Entidades;

namespace EM.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        readonly ContextoPrincipal _contextoPincipal;

        public ClienteRepository(ContextoPrincipal contextoPincipal)
        {
            _contextoPincipal = contextoPincipal;
        }

        public void Add(Cliente entity)
        {
            _contextoPincipal.Add(entity);
            _contextoPincipal.SaveChanges();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _contextoPincipal.Clientes;
        }
    }
}
