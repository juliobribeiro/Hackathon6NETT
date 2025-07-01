using Hackathon_6NETT.Services.Auth.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6NETT.Services.Auth.Services
{
    public class AuthService : IAuthService
    {
        public async Task<AuthResult> AutenticarAsync(string emailOuCpf, string senha)
        {
            // Lógica de autenticação mockada
            if ((emailOuCpf.Contains("@") || emailOuCpf.Length == 11) && senha == "123456")
                return new AuthResult { Sucesso = true, Token = "fake-jwt-token" };

            return new AuthResult { Sucesso = false, Mensagem = "Credenciais inválidas." };
        }
    }
}
