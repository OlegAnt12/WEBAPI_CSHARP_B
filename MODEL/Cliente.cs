using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hieratica.MODEL;

[Table("Cliente")]
[Index(nameof(BilheteIdentidade), IsUnique = true)]
[Index(nameof(NIF), IsUnique = true)]
[Index(nameof(NIS), IsUnique = true)]
public class Cliente
{
    [Key]
    public int ClienteId {get; set;}

    [Required]
    public string Nome {get; set;}
    
    [Required]
    public string BilheteIdentidade {get; set;}

    [Required]
    public string NIF {get; set;} 

    [Required]
    public string NIS {get; set;} 

    [Required]
    public string DenominacaoSocial {get; set;}

}
