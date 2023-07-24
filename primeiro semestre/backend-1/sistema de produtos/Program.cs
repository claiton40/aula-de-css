// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:
// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)
// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.
using System;
using System.Collections;
public class SamplesArrayList  {

public static void Main()  {

ArrayList produto = new ArrayList();
int senha =0;
string menu = (" ");
do
{
    Console.WriteLine($"digite sua senha");
     senha = int.Parse(Console.ReadLine());
    
} while (senha!= 123456);

do{
Console.ForegroundColor=ConsoleColor.Blue;
Console.WriteLine(@$"
       **************************
       * MERCEARIA DO CLAITINHO *
       **************************
            O que deseja?

        1- Cadastrar produto
        2- Listar produtos
        0- Sair");
menu = Console.ReadLine();
Console.ResetColor();

  switch (menu)
  {
  case "1":
 
for (var i = 0; i <= 3; i++)
{
Console.WriteLine($"PRODUTO");
produto.Add  (Console.ReadLine());
Console.WriteLine($"PRECO");
produto.Add  (Console.ReadLine());
Console.WriteLine($"deseja cadastrar novo produto?");
menu = Console.ReadLine().ToUpper();
if(menu == "N")
{
  i = (50);
}
  }

    break;
    case "2":
      for (var i = 0; i <= 3; i++)
     
{
Console.WriteLine();
Console.ForegroundColor=ConsoleColor.Blue;  
Console.WriteLine($"PRODUTO{produto[0]}");
Console.WriteLine($"PRECO{produto[1]}");
Console.WriteLine();
Console.ResetColor();
}
break;

case "0":

Console.WriteLine($"FIM");

 break;

  default:
  Console.WriteLine($"OPCAO INVALIDA");
  
    break;
}  
} while (menu != "0");

   }
}