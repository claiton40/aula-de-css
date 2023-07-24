using fyncao_list;
List<Produto> produtos = new List<Produto>();

produtos.Add(new Produto(123456, "camiseta do Jacare", 19.99));
produtos.Add(new Produto(123457, "camiseta do Cavalo", 19.99));
produtos.Add(new Produto(123458, "camiseta da Capivara", 19.99));

foreach (var iten in produtos)
{
    Console.WriteLine($"{iten.Codigo}, {iten.Nome}, {iten.Preco:C} {produtos.IndexOf(iten)}");
}

Produto produtobuscado = produtos.Find(x => x.Nome == "camiseta da Capivara");

produtobuscado.Preco = 199.90;

produtos.Insert(3, produtobuscado);

Console.WriteLine($"lista nova");

foreach (var iten in produtos)
{
    Console.WriteLine($"{iten.Codigo}, {iten.Nome}, {iten.Preco:C} {produtos.IndexOf(iten)}");
}
