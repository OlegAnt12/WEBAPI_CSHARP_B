namespace Hieratica.MODEL;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Cliente")]

public class Encomenda
{
    [Key]
    public int ID {get; set;}
    public int EncomendaId {get{return ID;} set{ID = value;}}

    [Required]
    [ForeignKey("ClienteId")]
    public Cliente? cliente {get; set;}

    public List<Produto> produto {get; set;} = new List<Produto>();

    public DateOnly data {get; set;}

    public string local {get; set;} = string.Empty;
}
