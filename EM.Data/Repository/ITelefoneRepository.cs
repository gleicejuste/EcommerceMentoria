using EM.Domain.Entidades;

namespace EM.Data.Repository
{
    public interface ITelefoneRepository
    {
        public interface ITelefoneRepository
        {
            IQueryable<Telefone> GetAll();

            void Add(Telefone entity);
        }
    }
}
