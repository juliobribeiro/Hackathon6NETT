using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6NETT.Services.Auth.Services
{
    public class AuthResult
    {
        public bool Sucesso { get; set; }
        public string Token { get; set; }
        public string Mensagem { get; set; }
    }
}
