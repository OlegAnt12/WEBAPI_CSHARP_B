using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hieratica.MODEL;

[Table("Produto")]
[Index (nameof(Designacao), IsUnique = true)]
public class Produto
{
    [Key]
    public int ProdutoId {get; set;}
    [Required]

    public string Designacao {get; set;}
    [Required]
    public int Quantidade {get; set;}

    [Required]
    [Column(TypeName = "Decimal(13,2)")]
    public double preco {get; set;}

    [Column(TypeName = "Decimal(13,2)")]

    public double taxaDeImposto { get; set; }

    //public TipoEmbalagem tipoEmbalagem {get; set;}
}