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
        public async Task<IActionResult> Adicionar([FromBody] ClienteNovoRequest clienteRequest)
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
            Cliente cliente = await _service.PesquisarPorIdAsync(id);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return NotFound();
        }

        [HttpGet("{nome}/{documento}/{email}/{dataInicial}/{dataFinal}")]
        public async Task<IActionResult> PesquisarComFiltros(
            [FromRoute] string nome, 
            [FromRoute] string documento, 
            [FromRoute] string email, 
            [FromRoute] string dataInicial, 
            [FromRoute] string dataFinal)
        {
            return Ok(await _service.PesquisarComFiltrosAsync(nome, documento, email, dataInicial, dataFinal));
        }

        [HttpPut()]
        public async Task<IActionResult> Editar([FromBody] ClienteRequest clienteRequest)
        {
            Cliente cliente = await _service.PesquisarPorIdAsync(clienteRequest.Id);
            if (cliente != null)
            {
                await _service.EditarAsync(clienteRequest);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{idCliente}")]
        public async Task<IActionResult> Excluir([FromRoute] Guid idCliente)
        {
            await _service.ExcluirAsync(idCliente);
            return Ok();
        }


        [HttpPut("{idCliente}/{ativo}")]
        public async Task<IActionResult> AtivarDesativar([FromRoute] Guid idCliente, [FromRoute] bool ativo)
        {
            await _service.AtivarDesativarAsync(idCliente, ativo);
            return Ok();

        }

    }

}
