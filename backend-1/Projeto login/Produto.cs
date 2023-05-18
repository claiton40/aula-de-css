namespace Projeto_login
{
    public class Produto
    {
        public int Codigo { get; set; } = 0;
        public string NomeProduto { get; set; } ="";
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        // public Usuario CadastroPor { get; set; }

        List<Produto> ListaDeProdutos = new List<Produto>();
        Produto produto = new Produto();
        string opcao="";
        public void Cadastrar()
        {
            Console.WriteLine($"Informe o nome do produto");
            NomeProduto = (Console.ReadLine());
            Console.WriteLine($"Informe o preço do produto");
            // produto.Codigo= int.Parse(Console.ReadLine());
            Preco = float.Parse(Console.ReadLine());
            DataCadastro = DateTime.Now;
            Console.WriteLine(@$"Deseja cadastrar um novo Produto?
            |S| -> Sim
            |N| -> Não");
            opcao = (Console.ReadLine()).ToUpper();
            //armazenar o objeto na lista
            for (Codigo = 0; Codigo < 200; Codigo++)
            {
                ListaDeProdutos.Add(produto);
            }
            if (opcao == "S")
            {
                Cadastrar();
            }
            else if (opcao == "N")
            {
                Login teste = new Login();
                teste.GerarMenu();
            }
            else
            {
                Console.WriteLine($"Opção invalida");
            }
        }
        public void Deletar()
        {
            //aqui vai a lógica
            Console.WriteLine($"Informe o codigo do produto a ser removido");
            int removeProduto = int.Parse(Console.ReadLine());
            //buscar um objeto na lista pelo seu código
            foreach (Produto Produto in ListaDeProdutos.ToList())
            {
                //remove-lo
                if (produto.Codigo == removeProduto)
                {
                    ListaDeProdutos.Remove(produto);
                }
                Console.WriteLine(@$"Deseja Remover um novo Produto?
            |S| -> Sim
            |N| -> Não");
                opcao = (Console.ReadLine()).ToUpper();
            }
            if (opcao == "S")
            {
                Deletar();
            }
            else if (opcao == "N")
            {
                Login teste = new Login();
                teste.GerarMenu();
            }
            else
            {
                Console.WriteLine($"Opção invalida");
            }
        }
        public void Listar()
        {
            foreach (Produto Produto in ListaDeProdutos)
            {
                Console.WriteLine(@$"
        Codigo:{Codigo}
        Nome: {NomeProduto}
        Marca: {Marca}
        Preço: {Preco:c}
        Data do cadastro{DataCadastro}");
            }
        }
    }
}




