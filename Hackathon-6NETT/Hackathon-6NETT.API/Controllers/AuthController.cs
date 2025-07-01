using Microsoft.AspNetCore.Mvc;
using Hackathon_6NETT.Applications.UseCases.AutenticarUsuario;

namespace Hackathon_6NETT.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AutenticarUsuarioHandler _handler;
        public AuthController(AutenticarUsuarioHandler handler)
        {
            _handler = handler;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AutenticarUsuarioCommand command)
        {
            var result = await _handler.Handle(command);
            return result.Sucesso ? Ok(result) : Unauthorized(result);
        }
    }
}
