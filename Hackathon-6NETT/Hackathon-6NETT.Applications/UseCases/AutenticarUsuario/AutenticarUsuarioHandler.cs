using Hackathon_6NETT.Applications.Interfaces;
using Hackathon_6NETT.Services.Auth.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6NETT.Applications.UseCases.AutenticarUsuario
{
    public class AutenticarUsuarioHandler
    {
        private readonly IAuthService _authService;
        public AutenticarUsuarioHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<AuthResult> Handle(AutenticarUsuarioCommand command)
        {
            return await _authService.AutenticarAsync(command.EmailOuCpf, command.Senha);
        }
    }
}
