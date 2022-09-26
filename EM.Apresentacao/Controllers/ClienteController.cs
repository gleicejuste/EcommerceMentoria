using EM.Domain.Modelos;
using EM.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace EM.Apresentacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] NovoClienteRequest clienteRequest)
        {
            await _service.AddAsync(clienteRequest);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }

        // [HttpGet("{id}")]
        // public IActionResult GetById(Guid id)
        // {
        //     Cliente cliente = _service.GetById(id);
        //     if (cliente != null)
        //     {
        //         //ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
        //         return Ok(cliente);
        //     }
        //     return NotFound();
        // }

        // [HttpPut("{id}")]
        // public IActionResult Put(Guid id, [FromBody] NovoClienteRequest clienteRequest)
        // {
        //     Cliente cliente = _service.GetById(id);
        //     if (cliente == null)
        //     {
        //         return NotFound();
        //     }

        //     //_mapper.Map(filmeDto, filme);
        //     //_context.SaveChanges();
        //     //return NoContent();
        // }

        // [HttpDelete("{id}")]
        // public IActionResult Delete(int id)
        // {
        //     //Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        //     //if (filme == null)
        //     //{
        //     //    return NotFound();
        //     //}

        //     //_context.Remove(filme);
        //     //_context.SaveChanges();
        //     //return NoContent();
        // }
    }
}
