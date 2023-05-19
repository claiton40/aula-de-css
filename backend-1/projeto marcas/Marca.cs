namespace projeto_marcas
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public string DataCadastro { get; set; }

        List<Marca> ListaDeMarcas = new List<Marca>();
        Marca NovaMarca = new Marca();
       public void Cadastrar()
       {
        ListaDeMarcas.Add(NovaMarca);
        Console.WriteLine($"Insira o codigo da Marca");
        this.Codigo = int.Parse(Console.ReadLine());
        Console.WriteLine($"Insira o Nome da Marca");
        this.NomeMarca = Console.ReadLine();
        this.DataCadastro = DateTime.Now.ToLongDateString();
        foreach (var NomeMarca in ListaDeMarcas)
        {
            Console.WriteLine($"marca cadastrada com sucesso");
        }
       }
       public void Listar()
       {

       }
       public void Deletar()
       {

       }
    }
}