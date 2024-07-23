using DAL;
using DTO;
using Hieratica.DAL;
using Hieratica.MODEL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service;

namespace Hieratica;

[Route("Hieratica/[Controller]")]
[ApiController]
public class FacturaController: ControllerBase
{
    private readonly HieraticaDBContext _factura;
    private readonly FacturaRepo facturaRepo;
    public FacturaController(HieraticaDBContext dBContext, FacturaRepo _facturaRepo)
    {
        _factura = dBContext;
        this.facturaRepo = _facturaRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetEmpresas()
    {
        var empresas = await _factura.Empresas.ToListAsync();

        return Ok(empresas);
    }

    [HttpGet("{FacturaId}")]
    public async Task<IActionResult> GetFactura([FromRoute] int FacturaId)
    {
        var factura = await _factura.Facturas.FindAsync(FacturaId);

        if (factura == null)
        {
            return NotFound();
        }

        return Ok(factura);
    }

    [HttpPost]
            public async Task<IActionResult> RegistoFactura([FromBody] NovaFactura novaFactura)
            {
                var facturaModel = novaFactura.ToFacturaServiceDTO();
                await facturaRepo.CreateAsync(novaFactura);
                return CreatedAtAction(nameof(GetFactura), new {FacturaId = facturaModel.FacturaId}, 
                novaFactura.ToFacturaServiceDTO());
            }
}
