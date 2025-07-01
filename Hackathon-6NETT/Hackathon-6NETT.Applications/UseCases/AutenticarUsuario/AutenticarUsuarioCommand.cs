using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6NETT.Applications.UseCases.AutenticarUsuario
{
    public class AutenticarUsuarioCommand
    {
        public string EmailOuCpf { get; set; }
        public string Senha { get; set; }
    }
}
