using DTO;
using Hieratica.MODEL;

namespace Service;

public static class FacturaService
{
     public static Factura ToFacturaServiceDTO ( this NovaFactura novoFactura)
        {
            return new Factura
            {
                empresa = novoFactura.empresa,
                venda = novoFactura.venda,
                montanteDeImposto = novoFactura.montanteDeImposto,
                motivoDeNaoLiquidacaoDoImposto = novoFactura.motivoDeNaoLiquidacaoDoImposto,
            };
        }
}
