using backend2.Model;

namespace backend2.View
{
    public class ProdutoView
    {
        // exibir dados
        public void Listar (List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine(@$"
                Codigo: {iten.Codigo}
                Nome: {iten.Nome}
                Preco: {iten.Preco:c}
                ");
                
            }
        }
    }
}