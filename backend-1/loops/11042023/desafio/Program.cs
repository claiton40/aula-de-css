//DESAFIOS
//Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int[] n = new int[6];
for (int i = 0; i < 6; i++)
{
Console.WriteLine($"insira o {i+1}º numero");
n [i] = int.Parse(Console.ReadLine());
}
for (int i = 1; i <=6; i++)
{
if (i%2==0)
{
Console.ForegroundColor=ConsoleColor.Magenta;
Console.WriteLine($"{i}--par");
Console.ResetColor();
}
else
{
Console.ForegroundColor=ConsoleColor.Yellow;
Console.WriteLine($"{i}--impar");
Console.ResetColor();
}
}