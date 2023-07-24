// 4) Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
// "Telefonou para a vítima?"
// "Esteve no local do crime?"
// "Mora perto da vítima?"
// "Devia para a vítima?"
// "Já trabalhou com a vítima?"
// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.
Console.WriteLine("Responda com s ou n");
Console.WriteLine("insira seu nome para comecar");
string suspeito = Console.ReadLine();
Console.WriteLine("Telefonou para a vítima?");
int p1 = Console.ReadLine();
Console.WriteLine("Telefonou para a vítima?");
int p2 = Console.ReadLine();
Console.WriteLine("Esteve no local do crime?");
int p3 = Console.ReadLine();
Console.WriteLine("Mora perto da vítima?");
int p4 = int.Parse (Console.ReadLine());
Console.WriteLine("Já trabalhou com a vítima?");
int p5 = int.Parse (Console.ReadLine());

int s = 0;



int result = (p1+p2+p3+p4+p5);

if (result == 2) {
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("O(a) Sr(a) "+suspeito+" e suspeito");
Console.ResetColor();
}
else if (result>=3||result<=4) {
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("O(a) Sr(a) "+suspeito+" e cumplice");
Console.ResetColor();
}