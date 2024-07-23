using DTO;
using Hieratica.DAL;
using Hieratica.MODEL;
using Service;

namespace DAL;

public class FacturaRepo
{
    private readonly HieraticaDBContext _registoRepoContext;
    public FacturaRepo(HieraticaDBContext hieraticaDBContext)
    {
        _registoRepoContext = hieraticaDBContext;
    }

    public async Task<Factura> CreateAsync(NovaFactura novaFactura)
    {
        await _registoRepoContext.Facturas.AddAsync(novaFactura.ToFacturaServiceDTO());
        await _registoRepoContext.SaveChangesAsync();
        return novaFactura.ToFacturaServiceDTO();
    }
}
