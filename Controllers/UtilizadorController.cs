using Hieratica.DAL;
using Hieratica.Service;
using DTO;

namespace Hieratica.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    

    namespace Namespace
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UtilizadorController : ControllerBase
        {
            private readonly HieraticaDBContext _dbcontext;
            private readonly RegistoRepo registoRepo;


            public UtilizadorController(HieraticaDBContext dbcontext, RegistoRepo _registoRepo)
            {
                _dbcontext = dbcontext;
                registoRepo = _registoRepo;
            }

            [HttpGet]
            public IActionResult GetUtilizadores()
            {
                var utilizadores = _dbcontext.Utilizadores.ToList();

                if (utilizadores==null)
                {
                    return NotFound();
                }

                return Ok(utilizadores);
            }
    
            [HttpGet("{UtilizadorId}")]
            public async Task<IActionResult> GetUtilizador([FromRoute]int UtilizadorId)
            {
                var utilizador = await _dbcontext.Utilizadores.FindAsync(UtilizadorId);

                if (utilizador==null)
                {
                    return NotFound();
                }

                return Ok(utilizador);
            }
    
            [HttpPost("Admin")]
        public async Task<IActionResult> CriarUtilizadorAdmin([FromBody] NovoUtilizadorDTO novoUtilizador)
        {
            var utilizadorModel = novoUtilizador.ToUtilizadorAdminServiceDTO();
            await registoRepo.CreateAsync(novoUtilizador);
            return CreatedAtAction(nameof(GetUtilizador), new {ID = utilizadorModel.ID}, 
            novoUtilizador.ToUtilizadorAdminServiceDTO());
        }

        [HttpPost]
        public async Task<IActionResult> CriarUtilizador([FromBody] NovoUtilizadorDTO novoUtilizador)
        {
            var utilizadorModel = novoUtilizador.ToUtilizadorServiceDTO();
            await registoRepo.CreateAsync(novoUtilizador);
            return CreatedAtAction(nameof(GetUtilizador), new {ID = utilizadorModel.ID}, 
            novoUtilizador.ToUtilizadorServiceDTO());
        }
    
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }
    
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }
    public class UtilizadorController
    {
        
    }
}