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
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] ClienteRequest cliente)
        {
            await _service.AdicionarAsync(cliente);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> PesquisarTodos()
        {
            return Ok(await _service.PesquisarTodosAsync());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> PesquisarPorId(Guid id)
        {
            Cliente cliente = await _service.PesquisarPorIdAsync(id);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Editar(Guid id, [FromBody] ClienteRequest clienteRequest)
        {
            Cliente cliente = await _service.PesquisarPorIdAsync(id);
            if (cliente != null)
            {
                await _service.EditarAsync(id, clienteRequest);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            Cliente cliente = await _service.PesquisarPorIdAsync(id);
            if (cliente != null)
            {
                await _service.ExcluirAsync(cliente);
                return Ok();
            }
            return NotFound();


            //await _service.ExcluirAsync(id);
            //return Ok();
        }
                 

        //[HttpPut("{id}")]
        //public async Task<IActionResult> AtivarDesativar(Guid id, [FromBody] bool ativoInativo)
        //{
        //    await _service.AtivarDesativarAsync(id, ativoInativo);
        //    return Ok();

        //}

    }

}
