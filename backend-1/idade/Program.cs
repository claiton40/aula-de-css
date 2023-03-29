// See https://aka.ms/new-console-template for more information
Console.WriteLine("insira o dia do nascimento: ");
int dia = int.Parse (Console.ReadLine());
Console.WriteLine("insira o mes do nascimento: ");
int mes = int.Parse (Console.ReadLine());
Console.WriteLine("insira o ano do nascimento: ");
int ano = int.Parse (Console.ReadLine());
Console.WriteLine("insira o hora do nascimento: ");
int hora = int.Parse (Console.ReadLine());
Console.WriteLine("insira os minutos: ");
int minuto = int.Parse (Console.ReadLine());
int resdias = (((2023-ano)*365));

Console.WriteLine(resdias);