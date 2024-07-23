namespace Hieratica.MODEL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;



[Table("Empresa")]
[Index (nameof(Designacao), IsUnique = true)]
[Index(nameof(NIF), IsUnique = true)]
[Index(nameof(Telelefone), IsUnique = true)]
public class Empresa
{
    [Key]
    public int EmpresaId {get; set;}

    [Required]
    public string Designacao {get; set;} = string.Empty;

    [Required]
    public string NIF {get; set;} = string.Empty;

    [Required]
    public string DenominacaoSocial {get; set;} = string.Empty;

    [Required]
    public string Telelefone {get; set;} = string.Empty;
    public string Endereco {get; set;} = string.Empty;
    //public TipoServico tipoServico {get; set;}
}
