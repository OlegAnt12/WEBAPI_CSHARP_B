using Hieratica.MODEL;

namespace DTO;

public class NovaFactura
{
    public int? empresa { get; set; }

    public int venda { get; set; }

    public double montanteDeImposto { get; set; }
    public string motivoDeNaoLiquidacaoDoImposto { get; set; }
}
