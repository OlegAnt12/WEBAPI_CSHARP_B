using Hieratica.DAL;
using Hieratica.DTO;
using Hieratica.MODEL;
using Hiearatica.Service;

namespace Hiearatica.DAL;

public class ProdutoRepo
{   
    private readonly HieraticaDBContext _registoRepoContext;
    public ProdutoRepo(HieraticaDBContext hieraticaDBContext)
    {
        _registoRepoContext = hieraticaDBContext;
    }

    public async Task<Produto> CreateAsync(NovoProduto novoProduto)
    {
        await _registoRepoContext.Produtos.AddAsync(novoProduto.ToProdutoServiceDTO());
        await _registoRepoContext.SaveChangesAsync();
        return novoProduto.ToProdutoServiceDTO();
    }
}
