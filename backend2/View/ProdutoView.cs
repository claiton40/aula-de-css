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
                Codigo: {item.Codigo}
                Nome: {item.Nome}
                Preco: {item.Preco:c}
                ");                
            }
        }
        public Produto cadastrar ()
        {
            Produto p = new Produto();

           Console.WriteLine($"Insira o Codigo");
           p.Codigo = int.Parse(Console.ReadLine());
           Console.WriteLine($"Nome");
           p.Nome = Console.ReadLine();Console.WriteLine($"Insira o preco");
           p.Preco = float.Parse(Console.ReadLine());
           
           return p;
        }


    }
}