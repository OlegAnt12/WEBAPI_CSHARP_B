using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Hieratica.DAL;
using Hieratica.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Hieratica.Controllers
{
    [Route("Hieratica[controller]")]
    [ApiController]
    public class LoginController: ControllerBase
    {
        private readonly HieraticaDBContext _loginContext;
        private readonly LoginServiceRepository _loginServiceRepo;

        public LoginController(HieraticaDBContext hieraticaDB, LoginServiceRepository loginServiceRepo)
        {
            _loginContext = hieraticaDB;
            _loginServiceRepo = loginServiceRepo;
        }

        [HttpGet("{user},{senha}")]
        public async Task<IActionResult> Login([FromRoute]string user, [FromRoute]string senha)
        {
            var _login = await _loginServiceRepo.OnLogin(user, senha);

            if (_login == null)
            {
                return Unauthorized();
            }

            return Ok(_login);
        }
    }
}