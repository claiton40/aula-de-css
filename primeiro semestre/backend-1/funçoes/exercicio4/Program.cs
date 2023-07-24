// - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro
// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

double gasolina=5.30;
double descontogasolina1=0.96;
double descontogasolina2=0.95;
double alcool=4.90;
double descontoalcol1=0.97;
double descontoalcol2=0.95;
double valorpago=0;
char combustivel =(' ');

Console.WriteLine(@$"Escolha
A - Alcool
G - Gasolina");
combustivel = char.Parse(Console.ReadLine().ToUpper());
Console.WriteLine($"Insira os litros");
double litro= double.Parse(Console.ReadLine());

if(combustivel=='G')
{
if (litro<=20)
{
    valorpago=Math.Round((gasolina*litro)*descontogasolina1, 2);
}
else if(litro>20){
    valorpago=Math.Round((gasolina*litro)*descontogasolina2, 2);
}
}
else if((combustivel=='A'))
{
    if (litro<=20)
{
    valorpago=Math.Round((alcool*litro)*descontoalcol1, 2);
}
else if(litro>20){
    valorpago=Math.Round((alcool*litro)*descontoalcol2, 2);
}
}
Console.WriteLine(@$"O valor devido e R${valorpago},00");
