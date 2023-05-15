namespace testando_interfaces_classes_a_porra_toda
{
    public class Produto
    {
        public string Modelo;
        public string ValidaPeriferico;
        // public string Periferico;
        public float Preco;
        List<Periferico> perifericos = new List<Periferico>();

        public void AddPeriferico()
        {
            if (ValidaPeriferico == "S")
            {

                foreach (var Periferico in perifericos)
                {
                    perifericos.Add(Periferico);
                    Periferico.Descricao= Console.ReadLine();
                    Periferico.Preco=float.Parse(Console.ReadLine());
                    Console.WriteLine($"{Periferico.Descricao}, {Periferico.Marca} adicionado com sucesso á {Modelo}");

                }
            }
            else if (ValidaPeriferico == "N")
            {
                Console.WriteLine($"{Modelo} apenas com recurso onboard");
            }
            else
            {
                Console.WriteLine($"Opção invalida");
            }
        }
    }
}


