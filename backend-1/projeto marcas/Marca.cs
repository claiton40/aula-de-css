namespace projeto_marcas
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public string DataCadastro { get; set; }

        public string opcao;
        public int deletar;

        public static List<Marca> ListaDeMarcas = new List<Marca>();




        public void Cadastrar()

        {
            do
            {

                Marca NovaMarca = new Marca();
                ListaDeMarcas.Add(NovaMarca);
                Console.WriteLine($"Insira o codigo da Marca");
                NovaMarca.Codigo = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira o Nome da Marca");
                NovaMarca.NomeMarca = Console.ReadLine();
                NovaMarca.DataCadastro = DateTime.Now.ToLongDateString();
                Console.WriteLine(@$"
                Marca Cdastrada com sucesso!
                *****************************
                Deseja incluir uma nova Marca?
                |S| ==> SIM
                |N| ==> NÃO");
                opcao = Console.ReadLine().ToUpper();
            } while (opcao == "S");
        }
        public void Listar()
        {
            foreach (var NovaMarca in ListaDeMarcas)
            {
                Console.WriteLine(@$"
            Nome: {NovaMarca.NomeMarca}
            Codigo: {NovaMarca.Codigo}
            Data do cadastro: {NovaMarca.DataCadastro}");
            }
        }
        public void Deletar()
        {

            do
            {
                Console.WriteLine("Insira o codigo da marca que deseja remover? ");
                int DelMarca = int.Parse(Console.ReadLine());

                foreach (var NovaMarca in ListaDeMarcas.ToList())

                {
                    if (NovaMarca.Codigo == DelMarca)
                    {
                        ListaDeMarcas.Remove(NovaMarca);
                    }
                    Console.WriteLine(@$"
                    Marca Removida  com sucesso!
                    *****************************
                    Deseja Remover uma nova Marca?
                    |S| ==> SIM
                    |N| ==> NÃO");
                    opcao = Console.ReadLine().ToUpper();

                }
            } while (opcao == "S");
        }
    }
}
