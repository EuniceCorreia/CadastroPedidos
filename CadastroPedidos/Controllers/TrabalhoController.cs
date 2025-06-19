using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabalhoController : Controller
    {
        private IServTrabalho _servTrabalho;

        public TrabalhoController()
        {
            _servTrabalho = new ServTrabalho();
        }

        [Route("/api/[Controller]/{id}")]
        [HttpGet]
        public IActionResult Trabalho(int id)
        {
            try
            {
                var trabalhoDto = _servTrabalho.Trabalho(id);

                return Ok(trabalhoDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
