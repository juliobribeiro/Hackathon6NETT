using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6NETT.Applications.UseCases.CriarPedido
{
    public class CriarPedidoCommand
    {
        public Guid ClienteId { get; set; }
        public List<Guid> ProdutosIds { get; set; }
        public string TipoEntrega { get; set; }
        public string JustificativaCancelamento { get; set; }
    }
}
