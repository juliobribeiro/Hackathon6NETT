using Hackathon_6NETT.Services.Auth.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6NETT.Services.Auth.interfaces
{
    public interface IAuthService
    {
        Task<AuthResult> AutenticarAsync(string emailOuCpf, string senha);
    }
}
