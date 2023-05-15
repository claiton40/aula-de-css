namespace testando_interfaces_classes_a_porra_toda
{
    public class Produto
    {
        public string Modelo;
        public string ValidaPeriferico;
        public string NovoPeriferico;
        public float Preco;
        

List<Periferico> produtos = new List<Periferico>();
Periferico equip = new Periferico();      

        public void AddPeriferico()
        {
            if (ValidaPeriferico == "S")
            { do
            {
                
            
            produtos.Add(new ());
            Console.WriteLine($"Insira a Descrição do periferico");
            equip.Descricao= Console.ReadLine();
            Console.WriteLine($"Insira a Marca do periferico");
            equip.Marca= Console.ReadLine();
            Console.WriteLine($"Insira o Preço do periferico");
            equip.Preco= float.Parse(Console.ReadLine());
            Console.WriteLine($"Deseja cadastra novo periferico?");
            NovoPeriferico=Console.ReadLine().ToUpper();
            
} while (NovoPeriferico == "S");
foreach (var equip in produtos)
{
    Console.WriteLine(@$"{equip.Descricao}, {equip.Marca}, {equip.Preco:c}");
    
}


;            }
            else if (ValidaPeriferico == "N")
            {
               Console.WriteLine($"Apenas com recurso onboard");
            }
            else
            {
                Console.WriteLine($"Opção invalida");
            }
        }
    }
}


