
using EM.Domain.Entidades;

namespace EM.Data.Repository
{
    public interface IClienteRepository
    {
        IQueryable<Cliente> GetAll();

        void Add(Cliente entity);

    }
}
