namespace Projeto_login
{
    public class Marca
    {
    
       public int Codigo {get; set;} = 0;
       public string NomeMarca {get; set;}="";
       public DateTime Data {get; set;}

  List<Marca> listaDeMarcas = new List<Marca>();
  Marca novaMarca = new Marca();
  string opcao="";
        public Marca Cadastrar() 
        {
            Console.WriteLine($"Informe o nome Marca");
            NomeMarca = (Console.ReadLine());
            Console.WriteLine(@$"Deseja cadastrar um novo Produto?
            |S| -> Sim
            |N| -> Não");
            opcao = (Console.ReadLine()).ToUpper();
            //armazenar o objeto na lista
            for (novaMarca.Codigo = 0; novaMarca.Codigo < 200; novaMarca.Codigo++)
            {
                listaDeMarcas.Add(novaMarca);
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
            return novaMarca;
        }
        public void Listar()
     {
        {
            foreach (Marca novaMarca in listaDeMarcas)
            {
                Console.WriteLine(@$"
        Codigo:{Codigo}
        Nome: {NomeMarca}
        Data do cadastro{Data}");
            }
        }    
     }
        public void Deletar() 
        {
             //aqui vai a lógica
            Console.WriteLine($"Informe o codigo do produto a ser removido");
            int removeMarca = int.Parse(Console.ReadLine());
            //buscar um objeto na lista pelo seu código
            foreach (Marca novaMarca in listaDeMarcas.ToList())
            {
                //remove-lo
                if (Codigo == removeMarca)
                {
                    listaDeMarcas.Remove(novaMarca);
                }
                Console.WriteLine(@$"Deseja Remover uma nova marca?
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
   
}
}