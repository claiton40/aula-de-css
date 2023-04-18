// esta aula vamos aplicar o seguinte projeto para gerenciamento de passagens aéreas pelo console:
// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.
// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).
// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).
int senha =0;
string menu = ("");
do
{
    Console.WriteLine($"digite sua senha");
     senha = int.Parse(Console.ReadLine());
    
} while (senha!= 123456);
// aqui to fazendo o menu
Console.ForegroundColor=ConsoleColor.Blue;
Console.WriteLine(@$"
    Bem vindo a Cogumelos Azuis Viagens

            O que deseja?

        1- Cadastrar passagem
        2- Listar Passagens
        0- Sair");
menu = Console.ReadLine();
Console.ResetColor();
//  aqui vou montar o banco de dados

string[,] passagem = new string[3, 4];

for (var i = 0; i <= 3; i++)
{
Console.WriteLine($"Nome");
passagem[0,0] = Console.ReadLine();
Console.WriteLine($"Origem");
passagem[0,1] = Console.ReadLine();
Console.WriteLine($"Destino");
passagem[0,2] = Console.ReadLine();
Console.WriteLine($"Data do voo");
passagem[0,3] = Console.ReadLine();
}
for (var i = 0; i <= 3; i++)
{
  Console.ForegroundColor=ConsoleColor.Blue;  
Console.WriteLine($"Nome");
Console.WriteLine(passagem[0,0]);
Console.WriteLine($"Origem");
Console.WriteLine(passagem[0,1]);
Console.WriteLine($"Destino");
Console.WriteLine(passagem[0,2]);
Console.WriteLine($"Data do voo");
Console.WriteLine(passagem[0,3]);
Console.ResetColor();
}

