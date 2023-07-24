//  Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)
using exercicio_0905;
int opcao=0;
double teste=0;
do
{
  Console.WriteLine(@$"Informe a convercao

|1|-|Dolar|===>|Real|
|2|-|Real|===>|Dolar| ");
opcao=int.Parse(Console.ReadLine());
} while (opcao!= 1 && opcao!= 2);
Console.WriteLine($"Insira o valor em dinheiro");
Cambio.Valor=Double.Parse(Console.ReadLine());
Console.WriteLine($"Insira o valor do cambio");

switch (opcao)
{
  case 1:

  Cambio.ValorCambio = double.Parse(Console.ReadLine());
    teste=Cambio.DolarReal(0);
    Console.WriteLine(teste);
    
    break;
case 2:

  Cambio.ValorCambio = double.Parse(Console.ReadLine());
  teste=Cambio.RealDolar(0);
    Console.WriteLine(teste);
  
    break;

  default:
  Console.WriteLine($"opcao invalida");
  
    break;
}


