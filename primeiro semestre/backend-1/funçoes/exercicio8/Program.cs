// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi declarado.
int numero = 0;
int[] conjunto = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Insira o {i + 1}º nome");
    conjunto[i] = int.Parse(Console.ReadLine());
}
Array.Reverse (conjunto);
foreach (int i in conjunto)
{
    Console.WriteLine(i);
}