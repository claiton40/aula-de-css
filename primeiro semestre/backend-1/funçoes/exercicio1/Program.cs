// criar metodo para: multiplicar, dividir, subtrair
string escolha = ("");

static float X(float n1, float n2)
{
    float n = n1 * n2;
    return n;
}
static float Dividir(float n1, float n2)
{
    float n = n1 / n2;
    return n;
}
static float Subtracao(float n1, float n2)
{
    float n = n1 - n2;
    return n;
}

Console.WriteLine($"insira o 1º nº");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine($"insira o 2º nº");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($@"escolha a operação
X - Multipicar
/ - Dividir
- - Subtrair");
escolha = Console.ReadLine().ToUpper();

while (escolha != "X" || escolha != "/" || escolha != "-")
{
    if (escolha == "X")
    {
        float teste = X(numero1, numero2);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"{numero1}X{numero2} = {teste}");
        Console.ResetColor();
        break;
    }


    else if (escolha == "/")
    {
        float teste = Dividir(numero1, numero2);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"{numero1}:{numero2} = {teste}");
        Console.ResetColor();
        break;
    }

    else if (escolha == "-")
    {
        float teste = Subtracao(numero1, numero2);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"{numero1}-{numero2} = {teste}");
        Console.ResetColor();
        break;
    }

    else
    {
        Console.WriteLine($@"escolha a operação
X - Multipicar
/ - Dividir
- - Subtrair");
        escolha = Console.ReadLine();
    }
}