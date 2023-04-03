// Faça um programa que leia três números e mostre o maior e o menor deles.
Console.WriteLine("insira um número"!);
int n1 = int.Parse (Console.ReadLine());
Console.WriteLine("insira outro número");
int n2 = int.Parse (Console.ReadLine());
Console.WriteLine ("insira outro número");
int n3 = int.Parse (Console.ReadLine());

if (n1> n2 && n1>n3){
Console.WriteLine (n1 + " é o maior");
}
else if (n2> n1 && n2>n3){
Console.WriteLine (n2 + " é o maior");
}
else if (n3> n1 && n3>n2) 
{
Console.WriteLine (n3 + " é o maior");
}
else {
Console.WriteLine ("Lute pela revolução comunista!!!!!!!");
}