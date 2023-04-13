// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
Console.WriteLine($"insira o ano de seu nascimento");
int voto = int.Parse (Console.ReadKey());
int verificacao=2023-voto;
if(verificacao<16)
{
    Console.WriteLine($"nao habilitado ao voto");    
}
else
{
Console.WriteLine($"habilitado ao voto");
}
