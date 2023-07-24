// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

int [] valor = new int [10];

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira o {i+1}º valor");
    valor[i] =  int.Parse(Console.ReadLine());
}
//Array.Sort(valor);

Console.WriteLine($"o menor e maior numero foram {valor.Min()} e {valor.Max()}");

