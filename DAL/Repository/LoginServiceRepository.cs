using DTO;
using Hieratica.DAL;
using Hieratica.DTO;
using Microsoft.EntityFrameworkCore;

namespace Hieratica.DAL;

public class LoginServiceRepository
{
    private readonly HieraticaDBContext _loginServiceRepoContext;

    public LoginServiceRepository(HieraticaDBContext hieraticaDBContext)
    {
        _loginServiceRepoContext = hieraticaDBContext;
    }

    public async Task<Login> OnLogin(string user, string password)
    {
        return await _loginServiceRepoContext.Utilizadores
        .Where(x => (x.Username.Equals(user) | x.Email.Equals(user) | 
        x.BilheteIdentidade.Equals(user)) && x.senha.Equals(password) && (int) x.estadoConta==1)
        .Select(x => new Login
        {
            Username = x.Username,
            senha = x.senha,
        }).FirstAsync();
    }
}
