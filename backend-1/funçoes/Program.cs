// criar metodo para: multiplicar, dividir, subtrair
static float X (float n1, float n2)
{
    float n=n1*n2;
    return n;
}
static float Dividir (float n1, float n2)
{
    float n=n1/n2;
    return n;
}
static float Subtracao (float n1, float n2)
{
    float n=n1*n2;
    return n;
}
Console.WriteLine($"insira o 1º nº");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine($"insira o 2º nº");
int numero2 = int.Parse(Console.ReadLine());

float teste = X(numero1, numero2 );

Console.WriteLine(teste);

