// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que: 
// - Se quantidade <= 5 o desconto será de 2% 
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3% 
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Bem vindo a mercearia do Claitinho");
Console.ResetColor();
Console.WriteLine($"Insira o produto");
string produto = Console.ReadLine();
Console.WriteLine($"Insira a quantidade");
int qnt = int.Parse(Console.ReadLine());
Console.WriteLine($"Insira o preco");
double preco = double.Parse((Console.ReadLine()));
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(@$"Produto: {produto}
Valor unitario: R${preco},00
Quantidade: {qnt}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;
if (qnt <= 5)
{
    preco = Math.Round((preco * qnt) - (preco * 0.03), 3);
    Console.WriteLine($"Total com desconto: R${preco}");
}
else if (qnt > 5 && qnt <= 10)
{
    preco = Math.Round((preco * qnt) - (preco * 0.03), 2);
    Console.WriteLine($"Total com desconto: R${preco}");
}
else if (qnt > 10)
{
    preco = Math.Round((preco * qnt) - (preco * 0.05), 3);
    Console.WriteLine($"Total com desconto: R${preco}");
}
Console.ResetColor();
