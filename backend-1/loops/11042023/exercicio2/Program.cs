
// // Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro

// // Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura for para a leitura dos números e a estrutura foreach para exibí-los
int[] n = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"insira o {i+1}º numero");
   n [i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
Console.BackgroundColor=ConsoleColor.Cyan;
Console.WriteLine($"O numero e {n[i]*2}");
Console.ResetColor();
}