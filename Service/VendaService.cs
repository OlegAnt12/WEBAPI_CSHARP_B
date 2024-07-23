using Hieratica.DTO;
using Hieratica.MODEL;

namespace Hieratica.Service;

public static class VendaService
{
     public static Venda ToVendaServiceDTO ( this NovaVenda novaVenda)
        {
            return new Venda
            {
                cliente = novaVenda.cliente,
                produto = novaVenda.produto,
                QuantidadeVendida = novaVenda.QuantidadeVendida,
                totalAPagar = novaVenda.totalAPagar,
                valorPago = novaVenda.valorPago,
                troco = novaVenda.troco,
                dataVenda = novaVenda.dataVenda,

            };
        }
}
