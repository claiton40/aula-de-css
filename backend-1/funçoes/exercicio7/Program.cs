// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.
string Achado = ("");
string[] nome = new string[10];
for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira o {i + 1}º nome");
    nome[i] = Console.ReadLine();
}
Console.WriteLine($"Qual nome vc procura?");
Achado = Console.ReadLine();
if (nome.Contains(Achado))
{
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("ACHEI!!!!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor=ConsoleColor.Blue;
    Console.WriteLine("NÃO ACHEI :(");
    Console.ResetColor();
}

// OPERADOR TERNARIO DE IF: Claitinho, decora essa merda!
// string resultadoBusca = nomeEncontrado == true ? "ACHEI" : "Não ACHEI";
// Console.WriteLine(resultadoBusca);
// Console.WriteLine(nomeEncontrado ? "ACHEI" : "Não ACHEI");