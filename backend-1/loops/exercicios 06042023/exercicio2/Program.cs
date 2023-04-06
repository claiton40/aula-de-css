// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.
Console.WriteLine($"informe seu login");
string login = Console.ReadLine();
Console.WriteLine($"informe sua senha");
string senha = Console.ReadLine();
while (senha == login)
{
    Console.WriteLine($"Senha invalida");
senha = Console.ReadLine();
}
