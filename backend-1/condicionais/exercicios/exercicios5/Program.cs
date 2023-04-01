// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.
Console.WriteLine("Insira  quantidade de maçãs");
int maca = int.Parse (Console.ReadLine()!);
double preco = (0.30);
if (maca >=12)
{
preco=0.25;
}
Console.WriteLine(preco*maca);

