// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira o resultado 1");
int time1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Insira o resultado 2");
int time2 = int.Parse(Console.ReadLine()!);

if (time1==time2) { 
    Console.WriteLine("Empate");
}

else if (time1>time2) 
{ 
    Console.WriteLine("vitoria time1");
    }    
    

else
 {
     Console.WriteLine("vitoria time2");
}

