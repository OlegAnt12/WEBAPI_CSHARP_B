using DAL;
using Hieratica.DAL;
using Hieratica.DTO;
using Hieratica.MODEL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hieratica.Controllers
{
    [Route("Hieratica[controller]")]
    [ApiController]
    public class EmpresaController: ControllerBase
    {
        private readonly HieraticaDBContext _empresaContext;
        private readonly RegistoRepo _registoRepo;

        public EmpresaController(HieraticaDBContext hieraticaDB)
        {
            _empresaContext = hieraticaDB;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmpresas()
        {
            var empresas = await _empresaContext.Empresas.ToListAsync();

            return Ok(empresas);
        }

        [HttpGet("{EmpresaId}")]
        public async Task<IActionResult> GetEmpresa([FromRoute] int EmpresaId)
        {
            var empresa = await _empresaContext.Empresas.FindAsync(EmpresaId);

            if (empresa == null)
            {
                return NotFound();
            }

            return Ok(empresa);
        }

        [HttpGet("{empresa}")]
        public async Task<Empresa> GetEmpresaForUtilizador([FromRoute] Empresa empresa)
        {
            return await _empresaContext.Empresas.FindAsync(empresa);

            
        }

        [HttpPost]
        public async Task<IActionResult> CriarEmpresa([FromBody] Empresa empresa)
        {
           await _empresaContext.Empresas.AddAsync(empresa);
           await _empresaContext.SaveChangesAsync();
          
            return Ok(empresa);
        }
    }
}