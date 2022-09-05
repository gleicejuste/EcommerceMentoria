using EM.Domain.Entidades;

namespace EM.Data.Repository
{
    public class TelefoneRepository : ITelefoneRepository
    {
        readonly ContextoPrincipal _contextoPincipal;

        public TelefoneRepository(ContextoPrincipal contextoPincipal)
        {
            _contextoPincipal = contextoPincipal;
        }

        public void Add(Telefone entity)
        {
            _contextoPincipal.Add(entity);
            _contextoPincipal.SaveChanges();
        }

        public IQueryable<Telefone> GetAll()
        {
            return _contextoPincipal.Telefones;
        }
    }
}
