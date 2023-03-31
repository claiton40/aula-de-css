// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.WriteLine("Insira a medida do lado1");
float ld1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Insira a medida do lado2");
float ld2 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Insira a medida do lado3");
float ld3 = float.Parse(Console.ReadLine()!);
if (ld1 == ld2 && ld2 == ld3 && ld1 == ld3)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (ld1 != ld2 && ld2 != ld3 && ld1 != ld3)
{
    Console.WriteLine("Triângulo Escaleno");
}
else
{
    Console.WriteLine("Triângulo Isósceles");
}