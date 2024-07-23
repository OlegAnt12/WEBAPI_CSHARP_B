
using DTO;
using Hieratica.MODEL;
using Hieratica.Service;

namespace Hieratica.DAL;

public class RegistoRepo
{
    private readonly HieraticaDBContext _registoRepoContext;
    public RegistoRepo(HieraticaDBContext hieraticaDBContext)
    {
        _registoRepoContext = hieraticaDBContext;
    }

    public async Task<Utilizador> CreateAsync(NovoUtilizadorDTO utilizadorServiceDTO)
    {
        await _registoRepoContext.Utilizadores.AddAsync(utilizadorServiceDTO.ToUtilizadorServiceDTO());
        await _registoRepoContext.SaveChangesAsync();
        return utilizadorServiceDTO.ToUtilizadorServiceDTO();
    }

    public async Task<Utilizador> CreateAdminAsync(NovoUtilizadorDTO utilizadorServiceDTO)
    {
        await _registoRepoContext.Utilizadores.AddAsync(utilizadorServiceDTO.ToUtilizadorAdminServiceDTO());
        await _registoRepoContext.SaveChangesAsync();
        return utilizadorServiceDTO.ToUtilizadorAdminServiceDTO();
    }
}