// 6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

// Exemplo: tabuada do 1, tabuada do 2, etc...
// Dica: utilize um laço dentro do outro.
int inicio =0;
for (inicio = 1; inicio <=10; inicio++)
{   
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WriteLine("Tabuada do "+inicio+":");
    Console.ResetColor();
for ( int i = 1; i <= 10; i++)
{
    Console.WriteLine(inicio+" X "+i+" = " +i*inicio); 
}
}