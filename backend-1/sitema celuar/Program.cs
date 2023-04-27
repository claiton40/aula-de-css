// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using sitema_celuar;

Console.WriteLine($@"o que vc deseja?
|L|---> Ligar o ClaiPhone
|D|---> Ligar o ClaiPhone");
 
Celular novo = new Celular();
novo.Ligado = (Console.ReadLine().ToUpper());
novo.LigDesl();
if (novo.opcao=true)
{
    Console.WriteLine($"menu1");
    
}
else if (novo.opcao=false)
{
    Console.WriteLine($"menu2");
    
}