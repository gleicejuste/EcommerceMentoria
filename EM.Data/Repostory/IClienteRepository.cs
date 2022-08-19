
using EM.Domain.Entidades;

namespace EM.Data.Repostory
{
    public interface IClienteRepository
    {
        IQueryable<Cliente> GetAll();

        void Add(Cliente entity);

    }
}
