using Hieratica.DAL;
using Hieratica.MODEL;
using Hieratica.DTO;
using Hieratica.Service;

namespace Hieratica.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    //using Hieratica.Models;


    namespace Hieratica.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class VendaController : ControllerBase
        {
            private readonly HieraticaDBContext _dbcontext;
            private readonly VendaRepo vendaRepo;
            public VendaController(HieraticaDBContext dbcontext, VendaRepo _venda)
            {
                this._dbcontext = dbcontext;
                this.vendaRepo = _venda;
            }
    
            [HttpGet]
            public async Task<IActionResult> GetVendas()
            {
                var vendas = await this._dbcontext.Vendas.ToListAsync();
                return Ok(vendas);
            }
    
            [HttpGet("{VendaId}")]
            public async Task<IActionResult> GetVendaById([FromRoute]int VendaId)
            {
                var venda = await _dbcontext.Vendas.FindAsync(VendaId);

                if(venda == null)
                {
                    return NotFound();
                }
                return Ok(venda);
            }
    
            [HttpPost]
            public async Task<IActionResult> RegistoFactura([FromBody] NovaVenda novaFactura)
            {
                var vendaModel = novaFactura.ToVendaServiceDTO();
                await vendaRepo.CreateAsync(novaFactura);
                return CreatedAtAction(nameof(GetVendaById), new {VendaId = vendaModel.VendaId}, 
                novaFactura.ToVendaServiceDTO());
            }
    
            [HttpPut("{id}")]
            public IActionResult PutVenda(int id, Venda model)
            {
                return NoContent();
            }
    
            [HttpDelete("{id}")]
            public ActionResult<Venda> DeleteVendaById(int id)
            {
                return Ok();
            }
        }
    }
    /*public class VendaController: DbContext
    {
        
    }*/
}