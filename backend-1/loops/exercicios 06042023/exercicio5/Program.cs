// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.
int totalEntrevistados =3;
char sexo;
int idade = 0;
int totalMasculino =0;
int totalFeminino =0;
int totalIdadeFeminino=0;
int totalIdadeMasculino=0;

for (int i = 0; i <= totalEntrevistados; i++)
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
totalIdadeMasculino=idade+totalIdadeMasculino;  
}
else if (sexo=='f')
    {
totalFeminino++;
totalIdadeFeminino=totalIdadeFeminino+idade; 
    }
else {
    Console.WriteLine($"opcao invalida");
    Console.WriteLine(@$"Informe o sexo
m - masculino
f - feminino");
sexo = char.Parse(Console.ReadLine());
Console.WriteLine(@$"Informe o idade");
idade = int.Parse(Console.ReadLine());
}
}
Console.WriteLine($"o total de e pessoas do sexo masculino e "+totalMasculino);
Console.WriteLine($"O total de e pessoas do sexo feminino e " + totalFeminino);
Console.WriteLine($"Média de idade de pessoas do sexo masculino e " + totalIdadeMasculino/totalMasculino);
Console.WriteLine($"Média de idade e pessoas do sexo feminino e "+totalIdadeFeminino/totalFeminino);