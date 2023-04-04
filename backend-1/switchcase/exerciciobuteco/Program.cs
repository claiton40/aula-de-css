// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.
Console.WriteLine($@"Buteco do Claitinho
Ambiente caseiro (bebe aqui, morre em casa)

");
Console.WriteLine($@"digite:
1 para corote
2 para jurupinga
3 para etanol");
char pinga = char.Parse(Console.ReadLine());
Console.WriteLine ("Acompanha gelo? s ou n");
if (gelo == "S")
{
    Console.WriteLine ("com gelo");
}

switch (pinga)
{
    case '1':
        Console.WriteLine($"voce escolheu corote");
        break;
    case '2':
        Console.WriteLine($"voce escolheu jurupinga");
        break;
    case '3':
        Console.WriteLine($"voce escolheu etanol");
        break;
default:
        Console.WriteLine($"nao temos essa opcao");        
        break;

}

// Console.WriteLine ("Acompanha gelo? s ou n");
//  char gelo =  char.Parse(Console.ReadLine().ToUpper());
// switch (gelo)
// {
//     case 'S':
//         Console.WriteLine($"bebida acompanha gelo");
//         break;
//     case 'N':
//         Console.WriteLine($"bebida sem gelo");
//         break;

// default:
//         Console.WriteLine($"opcao invalida");        
//         break;
// }

