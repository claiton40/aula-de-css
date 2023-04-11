// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.
int totalEntrevistados =10;
char sexo;
int idade = 0;
int totalMasculino =0;
int totalFeminino =0;
int totalIdadeFeminino=0;
int totalIdadeMasculino=0;

for (int i = 1; i <= totalEntrevistados; i++)
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
if(totalMasculino==0)
{
Console.WriteLine($"Total de pessoas do sexo masculino: "+totalMasculino);
Console.WriteLine($"Total de pessoas do sexo feminino: " + totalFeminino);
Console.WriteLine($"Média de idade de pessoas do sexo masculino: 0");
Console.WriteLine($"Média de idade e pessoas do sexo feminino: "+totalIdadeFeminino/totalFeminino);
}
else if (totalFeminino==0)
{
Console.WriteLine($"Total de pessoas do sexo masculino: "+totalMasculino);
Console.WriteLine($"Total de pessoas do sexo feminino: " + totalFeminino);
Console.WriteLine($"Média de idade de pessoas do sexo masculino: " + totalIdadeMasculino/totalMasculino);
Console.WriteLine($"Média de idade e pessoas do sexo feminino: 0");
}
else
{
Console.WriteLine($"Total de pessoas do sexo masculino: "+totalMasculino);
Console.WriteLine($"Total de pessoas do sexo feminino: " + totalFeminino);
Console.WriteLine($"Média de idade de pessoas do sexo masculino: " + totalIdadeMasculino/totalMasculino);
Console.WriteLine($"Média de idade e pessoas do sexo feminino: "+totalIdadeFeminino/totalFeminino);
}
