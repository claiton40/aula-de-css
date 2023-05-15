using testando_interfaces_classes_a_porra_toda;

List<Produto> Computador = new List<Produto>();

Produto produto = new Produto();


Computador.Add (produto);
Console.WriteLine($"Insira o modelo");
produto.Modelo = Console.ReadLine();
Console.WriteLine(@$"Adicona periferico?
|S|===> SIM
|N|===> NÃO");
produto.ValidaPeriferico = Console.ReadLine().ToUpper();
Console.WriteLine($"Insira o preço");
produto.Preco = float.Parse(Console.ReadLine());

