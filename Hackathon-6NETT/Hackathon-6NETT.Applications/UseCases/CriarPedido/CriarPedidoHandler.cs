using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon_6NETT.Data.Repositories;
using Hackathon_6NETT.Domain.Entities;
using Hackathon_6NETT.Domain.Interfaces;

namespace Hackathon_6NETT.Applications.UseCases.CriarPedido
{
    public class CriarPedidoHandler
    {
        //private readonly PedidoRepository _pedidoRepository;
        //public CriarPedidoHandler(IPedidoRepository pedidoRepository)
        //{
        //    _pedidoRepository = pedidoRepository;
        //}

        //public async Task<Result> Handle(CriarPedidoCommand command)
        //{
        //    var pedido = new Pedido(command.ClienteId, command.ProdutosIds, command.TipoEntrega);
        //    await _pedidoRepository.AdicionarAsync(pedido);
        //    return Result.Sucesso("Pedido criado com sucesso.");
        //}
    }
}
