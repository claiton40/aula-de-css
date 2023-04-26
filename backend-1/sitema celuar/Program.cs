// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using sitema_celuar;

Console.WriteLine($@"o que vc deseja?
|L|---> Ligar o Claitinhophone
|D|---> Ligar o Claitinhophone");

Celular novo = new Celular();

novo.Ligado=Console.ReadLine();

