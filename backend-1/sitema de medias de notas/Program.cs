using Projeto_Aluno_POO;

Aluno novoAluno = new Aluno();

Console.WriteLine($"Informe o nome do aluno: ");
novoAluno.Nome = Console.ReadLine();

Console.WriteLine($"Informe o curso do aluno: ");
novoAluno.Curso = Console.ReadLine();

Console.WriteLine($"Informe a idade do aluno: ");
novoAluno.Idade = Console.ReadLine();

Console.WriteLine($"Informe o RG do aluno: ");
novoAluno.Rg = Console.ReadLine();

Console.WriteLine($"Informe a média final do aluno: ");
novoAluno.MediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Valor bruto da mensalidade: ");
novoAluno.ValorMensalidade = float.Parse(Console.ReadLine());

Console.WriteLine($"O aluno é bolsista? s/n : ");
string resposta = Console.ReadLine().ToLower();

novoAluno.Bolsista = resposta == "s" ? true : false;

// Novoaluno.Bolsista = (Resposta == "S");

// If (Resposta == "S")
// {
//     Novoaluno.Bolsista = True;
// }
// Else
// {
//     Novoaluno.Bolsista = False;
// }

string opcao;

do
{
    Console.WriteLine($"****Menu****");
    Console.WriteLine(@$"
[1] - Média do aluno
[2] - Valor da mensalidade
[0] - Sair
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"A média do aluno {novoAluno.Nome} é : {novoAluno.VerMediaFinal()}");
            break;
        case "2":
            Console.WriteLine($"O valor da mensalidade é de : {novoAluno.VerMensalidade()}");
            break;
        case "0":
            Console.WriteLine($"Fim");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (opcao != "0");