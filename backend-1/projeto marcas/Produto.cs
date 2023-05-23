namespace projeto_marcas
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }
        public string opcao;
        public int deletar;
        string NomeMarca;
        
       public static List<Produto> ListaDeProdutos = new List<Produto>();
        
       
        public void Cadastrar()
        {
            do
            {
                Produto NovoProduto = new Produto();
                ListaDeProdutos.Add(NovoProduto);
                Console.WriteLine($"Insira o codigo do Produto");
                NovoProduto.Codigo = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira o Nome do Produto");
                NovoProduto.NomeProduto = Console.ReadLine(); 
                Console.WriteLine($"Insira a Marca do Produto");
                NomeMarca = Console.ReadLine();
                
                     Marca.ListaDeMarcas.Find((x => x.NomeMarca.Contains(this.NomeMarca)));
                
                Console.WriteLine($"Text"); 
                 
                Console.WriteLine($"Insira o preço e do Produto");
                NovoProduto.Preco = float.Parse(Console.ReadLine());
                NovoProduto.DataCadastro =DateTime.Now;
                 Console.WriteLine(@$"
                Produto Cdastrado com sucesso!
                *****************************
                Deseja incluir um novo Produto?
                |S| ==> SIM
                |N| ==> NÃO");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao == "S");
        }
        public void Listar()
        {
            foreach (var NovoProduto in ListaDeProdutos)
            {
            Console.WriteLine(@$"
            Nome: {NovoProduto.NomeProduto}
            Codigo: {NovoProduto.Codigo}
            Preço: {NovoProduto.Preco:c}
            Data do cadastro: {NovoProduto.DataCadastro}
            Marca: {NovoProduto.Marca.NomeMarca}
            ");
            }
        }
        public void Deletar()
        {

            do
            {
                Console.WriteLine("Insira o codigo do Produto que deseja remover? ");
                int DelProduto = int.Parse(Console.ReadLine());

                foreach (var NovoProduto in ListaDeProdutos.ToList())

                {
                    if (NovoProduto.Codigo == DelProduto)
                    {
                        ListaDeProdutos.Remove(NovoProduto);
                    }
                    Console.WriteLine(@$"
                    Marca Removida  com sucesso!
                    *****************************
                    Deseja Remover uma novo Produto?
                    |S| ==> SIM
                    |N| ==> NÃO");
                    opcao = Console.ReadLine().ToUpper();

                }
            } while (opcao == "S");
        }
    }
}