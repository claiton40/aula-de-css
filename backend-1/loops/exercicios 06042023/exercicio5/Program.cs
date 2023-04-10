// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.
char sexo;
int idade = 0;
int totalMasculino =0;
int totalFeminino =0;
int totalIdadeFeminino=0;
int totalIdadeMasculino=0;
float mediaIdadeMasculino= 0;
float mediaIdadeFeminino= 0;
for (int i = 1; i <= 3; i++)
{    
Console.WriteLine(@$"Informe o sexo
m - masculino
f - feminino");
sexo = char.Parse(Console.ReadLine());
Console.WriteLine(@$"Informe o idade");
idade = int.Parse(Console.ReadLine());
if (sexo=='m')
{
totalMasculino++;
totalIdadeMasculino=totalIdadeMasculino+idade;    
}
else if (sexo=='f')
    {
totalFeminino++;
totalIdadeFeminino=totalIdadeFeminino+idade;
    }
else{
    Console.WriteLine($"opcao invalida");
    Console.WriteLine(@$"Informe o sexo
m - masculino
f - feminino");
sexo = char.Parse(Console.ReadLine());
Console.WriteLine(@$"Informe o idade");
idade = int.Parse(Console.ReadLine());
}
}

Console.WriteLine(totalMasculino);
Console.WriteLine(totalFeminino);
Console.WriteLine(mediaIdadeMasculino);
Console.WriteLine(mediaIdadeFeminino);