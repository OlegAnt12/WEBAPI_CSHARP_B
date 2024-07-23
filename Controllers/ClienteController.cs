using DAL;
using DTO;
using Hieratica.DAL;
using Hieratica.MODEL;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Hieratica.Controllers
{
    [Route("Hieratica/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly HieraticaDBContext _clienteContext;
        private readonly ClienteRepo clienteRepo;

        public ClienteController(HieraticaDBContext hieraticaDB, ClienteRepo _clienteRepo)
        {
            _clienteContext = hieraticaDB;
            this.clienteRepo = _clienteRepo;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var clientes = _clienteContext.Clientes.ToList();

            return Ok(clientes);
        }

        [HttpGet("{ClienteId}")]
        public async Task<IActionResult> GetCliente([FromRoute] int ClienteId)
        {
            var cliente = await _clienteContext.Clientes.FindAsync(ClienteId);

            return Ok(cliente);
        }

        [HttpPost]
            public async Task<IActionResult> AddCliente([FromBody] NovoCliente novoCliente)
            {
                var clienteModel = novoCliente.ToClienteServiceDTO();
                await clienteRepo.CreateAsync(novoCliente);
                return CreatedAtAction(nameof(GetCliente), new {ClienteId = clienteModel.ClienteId}, 
                novoCliente.ToClienteServiceDTO());
            }
    }
}