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
        public async Task<IActionResult> Adicionar([FromBody] ClienteRequest clienteRequest)
        {
            await _service.AdicionarAsync(clienteRequest);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> PesquisarTodos()
        {
            return Ok(await _service.PesquisarTodosAsync());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> PesquisarPorId([FromRoute] Guid id)
        {
            ClienteResponse clienteResponse = await _service.PesquisarPorIdAsync(id);
            if (clienteResponse != null)
            {
                return Ok(clienteResponse);
            }
            return NotFound();
        }

        [HttpGet("{nome}/{documento}/{email}")]
        public async Task<IActionResult> PesquisarComFiltros(
            [FromRoute] string nome, [FromRoute] string documento, [FromRoute] string email)
        {
            return Ok(await _service.PesquisarComFiltrosAsync(nome, documento, email));
        }

        [HttpPut()]
        public async Task<IActionResult> Editar([FromBody] ClienteRequest clienteRequest)
        {
            ClienteResponse clienteResponse = await _service.PesquisarPorIdAsync(clienteRequest.Id);
            if (clienteResponse != null)
            {
                await _service.EditarAsync(clienteRequest);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir([FromRoute] Guid id)
        {
            Cliente cliente = await _service.PesquisarPorIdRetornoClienteAsync(id);
            if (cliente != null)
            {
                await _service.ExcluirAsync(cliente);
                return Ok();
            }
            return NotFound();

        }


        [HttpPut("{id}/{ativo}")]
        public async Task<IActionResult> AtivarDesativar([FromRoute] Guid id, [FromRoute] bool ativo)
        {
            await _service.AtivarDesativarAsync(id, ativo);
            return Ok();

        }

    }

}
