
using Hieratica.DAL;
using Hieratica.DTO;
using Hieratica.MODEL;
using Hieratica.Service;
using Service;

namespace Hieratica.DAL;

public class VendaRepo
{
    private readonly HieraticaDBContext _registoRepoContext;
    public VendaRepo(HieraticaDBContext hieraticaDBContext)
    {
        _registoRepoContext = hieraticaDBContext;
    }

    public async Task<Venda> CreateAsync(NovaVenda vendaDTO)
    {
        await _registoRepoContext.Vendas.AddAsync(vendaDTO.ToVendaServiceDTO());
        await _registoRepoContext.SaveChangesAsync();
        return vendaDTO.ToVendaServiceDTO();
    }
}
