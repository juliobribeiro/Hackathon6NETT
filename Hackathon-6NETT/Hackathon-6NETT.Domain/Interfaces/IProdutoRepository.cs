using Hackathon_6NETT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6NETT.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> BuscarPorTipoEDisponibilidade(string tipo, bool? disponivel);
    }
}
