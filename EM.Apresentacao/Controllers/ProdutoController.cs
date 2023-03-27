using EM.Domain.Entidades;
using EM.Domain.Modelos;
using EM.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace EM.Apresentacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] ProdutoNovoRequest request)
        {
            await _service.AdicionarAsync(request);
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
            Produto produto = await _service.PesquisarPorIdAsync(id);
            if (produto != null)
            {
                return Ok(produto);
            }
            return NotFound();
        }

        //[HttpGet("{nome}/{documento}/{email}/{dataInicial}/{dataFinal}")]
        //public async Task<IActionResult> PesquisarComFiltros(
        //    [FromRoute] string nome,
        //    [FromRoute] string documento,
        //    [FromRoute] string email,
        //    [FromRoute] string dataInicial,
        //    [FromRoute] string dataFinal)
        //{
        //    return Ok(await _service.PesquisarComFiltrosAsync(nome, documento, email, dataInicial, dataFinal));
        //}

        [HttpPut()]
        public async Task<IActionResult> Editar([FromBody] ProdutoRequest request)
        {
            //Produto produto = await _service.PesquisarPorIdAsync(request.Id);
            //if (produto != null)
            //{
            //    await _service.EditarAsync(request);
            //    return Ok();
            //}
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir([FromRoute] Guid id)
        {
            await _service.ExcluirAsync(id);
            return Ok();
        }


        [HttpPut("{id}/{ativo}")]
        public async Task<IActionResult> AtivarDesativar([FromRoute] Guid id, [FromRoute] bool ativo)
        {
            await _service.AtivarDesativarAsync(id, ativo);
            return Ok();

        }

    }

}
