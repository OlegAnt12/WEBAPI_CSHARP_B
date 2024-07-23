using Hieratica.MODEL;

namespace DTO;

public class AddUtilizadorDTO
{
    public string NomeCompleto {get; set;} 

    
     public string Username {get; set;}

    
    public string Email {get; set;} 

    
    public string Telelefone {set; get;} 

    
    public string BilheteIdentidade {get; set;} 

    
    public string senha {get; set;} 

    
    public EstadoConta estadoConta{set; get;} 

    
    public Perfil perfil{set; get;} 
}
