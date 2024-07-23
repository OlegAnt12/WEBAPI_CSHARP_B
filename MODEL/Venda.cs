using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hieratica.MODEL;


[Table("Venda")]
public class Venda
{
    [Key]
    public int VendaId {get; set;}

    [Required]
    [ForeignKey("ClienteId")]
    public int? cliente {get; set;}

    [Required]
    [ForeignKey("ProdutoId")]
    public int produto {get; set;}

    [Required]
    public int QuantidadeVendida {get; set;}

    [Column(TypeName = "Decimal(13,2)")]

    public double totalAPagar { get; set; }

    [Required]
    [Column(TypeName = "decimal(13,2)")]
    public Decimal valorPago {get; set;}

    [Required]
    [Column(TypeName = "Decimal(13,2)")]
    public Decimal troco {get; set;}

    public DateOnly dataVenda {get; set;}
}
