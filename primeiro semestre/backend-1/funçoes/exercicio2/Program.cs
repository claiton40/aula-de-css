//faça um método para calcular imposto sobre a renda
//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto
//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda
float imposto = 0;
Console.WriteLine($"informe sua renda");
float rendimento = float.Parse(Console.ReadLine());

static float impostoelegal(float rendimento, float imposto)
{
    if (rendimento < +1500)
    {
        Console.WriteLine(0);

    }
    else if (rendimento >= 1501 && rendimento <= 3500)
    {
        imposto = 20 * rendimento / 100;
    }
    else if (rendimento >= 3051 && rendimento <= 6000)
    {
        imposto = 25 * rendimento / 100;
    }
    else if (rendimento > 6000)
    {
        imposto = 35 * rendimento / 100;
    }
    else
    {
        Console.WriteLine($"qqr coisa");

    }
    return imposto;

}

float teste = impostoelegal(rendimento, imposto);
if (teste == 0)
{
    Console.WriteLine($"isento de imposto");
}
else
{
    Console.WriteLine($" O Imposto devido e de R$ {teste},00");
}






