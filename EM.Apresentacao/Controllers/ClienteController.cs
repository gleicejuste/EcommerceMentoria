

using EM.Data;
using EM.Data.Repository;
using EM.Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace EM.Apresentacao.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        readonly ContextoPrincipal _contextoPrincipal;

        public ClienteController(ContextoPrincipal contextoPrincipal)
        {
            _contextoPrincipal = contextoPrincipal;
        }

        [HttpPost]
        public void Add([FromBody] Cliente clienteSalvar)
        {
            ClienteRepository repo = new ClienteRepository(_contextoPrincipal);
            repo.Add(clienteSalvar);
            
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            ClienteRepository repo = new ClienteRepository(_contextoPrincipal);
            return repo.GetAll();
        }
    }
}
