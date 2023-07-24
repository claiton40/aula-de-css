// Faça um programa que receba um número inteiro e mostre a sua tabuada.
int i = 1;
Console.WriteLine($"informe um numero");
int numero = int.Parse(Console.ReadLine());
for ( i = 0; i <= 10; i++)
{
Console.WriteLine($"{numero} X {i} = {numero*i}");
}

