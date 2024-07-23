namespace Hieratica.MODEL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("Factura")]

public class Factura
{
    [Key]
    public int FacturaId { get; set; }

    [Required]
    [ForeignKey("EmpresaId")]
    public int? empresa { get; set; }

    [Required]
    [ForeignKey("VendaId")]
    public int? venda { get; set; }
    
    [Column(TypeName = "Decimal(13,2)")]

    public double montanteDeImposto { get; set; }
    public string motivoDeNaoLiquidacaoDoImposto { get; set; }
}
