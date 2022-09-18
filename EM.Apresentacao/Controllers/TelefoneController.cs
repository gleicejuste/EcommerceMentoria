using EM.Data;
using EM.Data.Repository;
using EM.Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace EM.Apresentacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelefoneController : ControllerBase
    {


        readonly ContextoPrincipal _contextoPrincipal;

        public TelefoneController(ContextoPrincipal contextoPrincipal)
        {
            _contextoPrincipal = contextoPrincipal;
        }

        [HttpPost]
        public void Add([FromBody] Telefone telefoneSalvar)
        {
            TelefoneRepository repo = new TelefoneRepository(_contextoPrincipal);
            repo.Add(telefoneSalvar);

        }

        [HttpGet]
        public IEnumerable<Telefone> Get()
        {
            TelefoneRepository repo = new TelefoneRepository(_contextoPrincipal);
            return repo.GetAll();
        }
    }
}
