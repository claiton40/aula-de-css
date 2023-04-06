// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.
Console.WriteLine($"informe a nota");
int nota = int.Parse ((Console.ReadLine()));
while (nota>10 || nota<0)
{
Console.WriteLine($"valor invalido");
nota = int.Parse ((Console.ReadLine()));
}