using backend2.Model;
using backend2.View;

namespace backend2.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView ProdutoView = new ProdutoView();
    //    metodo controlador de produtos
    public void ListarProdutos()
    {
        List<Produto> produtos =  produto.Ler();
        ProdutoView.Listar(produtos);
    }
    }

}