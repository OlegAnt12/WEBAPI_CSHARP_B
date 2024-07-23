using Hieratica.MODEL;

namespace Hieratica.DTO;

public class NovaVenda
{
    public int cliente {get; set;}

    
    
    public int produto {get; set;}

    
    public int QuantidadeVendida {get; set;}

    

    public double totalAPagar { get; set; }

    
    
    public Decimal valorPago {get; set;}

    
    public Decimal troco {get; set;}

    public DateOnly dataVenda {get; set;}
}
