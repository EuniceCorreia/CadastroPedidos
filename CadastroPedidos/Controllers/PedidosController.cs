using Microsoft.AspNetCore.Mvc;
using Pedidos.DTO;
using Services;

namespace CatalogoProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly PedidoDomain _pedidoDomain;

        public PedidosController()
        {
            _pedidoDomain = new PedidoDomain();
        }

        [HttpPost("/CriarPedidos")]
        public IActionResult CriarPedido(InserirPedidosDTO dadosDoPedido)
        {
            try
            {
                _pedidoDomain.CriarPedido(dadosDoPedido);

                return Ok("Pedido inserido com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("/ExcluirPedidos")]
        public IActionResult ExcluirPedido(ExcluirPedidosDTO dadosDoPedido)
        {
            try
            {
                _pedidoDomain.ExcluirPedido(dadosDoPedido);

                return Ok("Pedido excluído com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
        [HttpGet("/{codigoUsuario}")]
        public IActionResult BuscarPorUsuario(int codigoUsuario)
        {
            try
            {
                var usuarios = _pedidoDomain.BuscarPorUsuario(codigoUsuario);

                return Ok(usuarios);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
