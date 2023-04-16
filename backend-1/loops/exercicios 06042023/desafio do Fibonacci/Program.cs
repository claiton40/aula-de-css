// //  Pesquise como funciona o algoritmo Fibonacci.
// //  Faça um programa que gere a série até que o valor seja maior que 500.
// A Sequência de Fibonacci tem como primeiros termos os números 0 e 1 e, a seguir, cada termo subsequente é obtido pela soma dos dois termos predecessores: 
int a=0;
int b=1;
List<int> Fibonacci = new List<int>();

while(Fibonacci.Count() < 10){
    Fibonacci.Add(a);
    int c = a + b;
    a = b;
    b = c;

}

foreach (var item in Fibonacci)
{
    
Console.WriteLine(item);
}