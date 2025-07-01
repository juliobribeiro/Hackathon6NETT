using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6NETT.Domain.Entities
{
    public class Pedido
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid ClienteId { get; private set; }
        public List<Guid> ProdutosIds { get; private set; }
        public string TipoEntrega { get; private set; }
        public string Status { get; private set; } = "Pendente";
        public DateTime DataCriacao { get; private set; } = DateTime.UtcNow;

        public Pedido(Guid clienteId, List<Guid> produtosIds, string tipoEntrega)
        {
            ClienteId = clienteId;
            ProdutosIds = produtosIds;
            TipoEntrega = tipoEntrega;
        }
    }
}
