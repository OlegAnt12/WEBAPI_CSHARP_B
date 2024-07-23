using DTO;
using Hieratica.DAL;
using Hieratica.MODEL;
using Service;

namespace DAL;

public class ClienteRepo
{
    private readonly HieraticaDBContext _registoRepoContext;
    public ClienteRepo(HieraticaDBContext hieraticaDBContext)
    {
        _registoRepoContext = hieraticaDBContext;
    }

    public async Task<Cliente> CreateAsync(NovoCliente novoCliente)
    {
        await _registoRepoContext.Clientes.AddAsync(novoCliente.ToClienteServiceDTO());
        await _registoRepoContext.SaveChangesAsync();
        return novoCliente.ToClienteServiceDTO();
    }
}
