using Hieratica.DAL;
using Hieratica.MODEL;
using Hieratica.Service;
using Hieratica.DTO;

namespace Hieratica.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Hiearatica.DAL;
    using Hiearatica.Service;
    using Microsoft.AspNetCore.Http.HttpResults;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    //using .Models;


    namespace Hieratica.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ProdutoController : ControllerBase
        {
            private readonly HieraticaDBContext _dbcontext;
            private readonly ProdutoRepo _produtoRepo;
            public ProdutoController(HieraticaDBContext dbcontext, ProdutoRepo produtoRepo)
            {
                _dbcontext = dbcontext;
                _produtoRepo = produtoRepo;
            }
    
            [HttpGet]
            public async Task<IActionResult> GetProdutos()
            {   
                var produtos = await _dbcontext.Produtos.ToListAsync();

                return Ok(produtos);
            }
    
            [HttpGet("{ProdutoId}")]
            public async Task<IActionResult> GetProdutoById([FromRoute]int ProdutoId)
            {
                var produto= await this._dbcontext.Produtos.FindAsync(ProdutoId);

                if(produto==null)
                {
                    return NotFound();
                }
                return Ok(produto);
            }

            [HttpPost]
            public async Task<IActionResult> CriaProduto([FromBody] NovoProduto novoProduto)
            {
                var produtoModel = novoProduto.ToProdutoServiceDTO();
                await _produtoRepo.CreateAsync(novoProduto);
                return CreatedAtAction(nameof(GetProdutoById), new {ProdutoId = produtoModel.ProdutoId}, 
                novoProduto.ToProdutoServiceDTO());
            }
    
            
        }

        
    }
    
}