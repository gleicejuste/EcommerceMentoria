using EM.Domain.Entidades;
using EM.Domain.Modelos;
using EM.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace EM.Apresentacao.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Add([FromBody] NovoClienteRequest clienteRequest)
        {
            _service.Add(clienteRequest);
            return Ok();
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return (IEnumerable<Cliente>)Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            Cliente cliente = _service.GetById(id);
            if (cliente != null)
            {
                //ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
                return Ok(cliente);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] NovoClienteRequest clienteRequest)
        {
            Cliente cliente = _service.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }

            //_mapper.Map(filmeDto, filme);
            //_context.SaveChanges();
            //return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            //if (filme == null)
            //{
            //    return NotFound();
            //}

            //_context.Remove(filme);
            //_context.SaveChanges();
            //return NoContent();
        }
    }
}
