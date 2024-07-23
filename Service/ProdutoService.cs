using Hieratica.DTO;
using Hieratica.MODEL;

namespace Hiearatica.Service;

public static class ProdutoService
{
    public static Produto ToProdutoServiceDTO ( this NovoProduto novoProduto)
        {
            return new Produto
            {
                Designacao = novoProduto.Designacao,
                Quantidade = novoProduto.Quantidade,
                preco = novoProduto.preco,
                taxaDeImposto = novoProduto.taxaDeImposto,
            };
        }
}
