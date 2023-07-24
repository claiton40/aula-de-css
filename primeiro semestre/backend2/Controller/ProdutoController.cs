using backend2.Model;
using backend2.View;

namespace backend2.Controller
{
    // classe de controle das funções da aplicação
    public class ProdutoController
    {
        // estanciando objeto da classe Produto para acessar a Model
        Produto produto = new Produto();
        // estanciando objeto da classe ProdutoView para acessar a View
        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para listar os produtos
        public void ListarProdutos()
        {
            // criando um metodo tipo lista chamando o metodo ler da Model para obter os dados
            List<Produto> produtos = produto.Ler();
            // chamando o o listar lá na View
            produtoView.Listar(produtos);
        }

        // metodo para o controlador cadastrar produtos
         public void CadastrarProdutos()
        {
            // chamando metodo da Model obtendo os dados a partir da View.
           produto.Inserir(produtoView.cadastrar());
        }
    }
}
