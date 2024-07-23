namespace Hieratica.MODEL;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;



[Table("Utilizador")]
[Index (nameof(Username), IsUnique = true)]
[Index(nameof(BilheteIdentidade), IsUnique = true)]
[Index(nameof(Email), IsUnique = true)]
[Index(nameof(Telelefone), IsUnique = true)]
public class Utilizador
{
    [Key]
    public int ID {get; set;}

    [Required]
    public string NomeCompleto {get; set;} = string.Empty;

    [Required]
     public string Username {get; set;} = string.Empty;

    [Required]
    public string Email {get; set;} = string.Empty;

    [Required]
    public string Telelefone {set; get;} = string.Empty;

    [Required]
    [StringLength (14)]
    public string BilheteIdentidade {get; set;} = string.Empty;

    [Required]
    public string senha {get; set;} = string.Empty;

    [Required]
    public EstadoConta estadoConta{set; get;} 

    [Required]
    public Perfil perfil{set; get;} 

    [Required]
    [ForeignKey("EmpresaId")]
    public int empresa{set; get;}



}
