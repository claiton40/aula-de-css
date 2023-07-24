// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.
Console.WriteLine ("Insira o dia de seu nascimento");
int dia = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Insira o mês de seu nascimento em números");
int mes = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Insira o ano de seu nascimento no formato XXXX");
int ano = int.Parse(Console.ReadLine()!);

if (dia>31 | mes>12 | ano>2013){
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Data digitada Invalida");
Console.ResetColor();
}

else {
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Parabéns!!!!!");
Console.ResetColor();
}

