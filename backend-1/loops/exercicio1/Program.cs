//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));
Console.WriteLine($"informe seu nome");
string nome = (Console.ReadLine());
while (nome == "")
{
    Console.WriteLine($"Campo vazio invalido. Informe seu nome");
   nome = Console.ReadLine();
}

Console.WriteLine($"informe a idade");
int idade = int.Parse ((Console.ReadLine()));
while (idade == 0 | idade>100)
{
    Console.WriteLine($"idade invalida. Informe sua idade");
   idade = int.Parse ((Console.ReadLine()));
}
Console.WriteLine($"informe seu salario");
float salario = float.Parse ((Console.ReadLine()));
while (salario<=0)
{
    Console.WriteLine($"valor menor que zero. Informe seu salario");
   salario = float.Parse ((Console.ReadLine()));
}
Console.WriteLine(@$"informe seu estado civil
's'- solteiro(a))
'c'- casado(a))
'v'- viúvo(a))
'd'- divorciado(a))");
char estadoCivil = char.Parse((Console.ReadLine()));

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine (@$"Nome: {nome}
Idade: {idade}
Salario:  {salario}
");
if (estadoCivil == 's' )
{
    Console.WriteLine ("Estado civil: Solteiro");
}
else if (estadoCivil == 'v')
{
    Console.WriteLine ("Estado civil: Viuvo");
}
else if (estadoCivil == 'd')
{
    Console.WriteLine ("Estado civil: Divorciado");
}
else if (estadoCivil == 'c')
{
    Console.WriteLine ("Estado civil: Casado");
}
else
{
    Console.WriteLine ("Valor invalido");
    salario = char.Parse ((Console.ReadLine()));
}
Console.ResetColor();


