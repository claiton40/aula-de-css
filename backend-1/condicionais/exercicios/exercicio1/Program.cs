// See https://aka.ms/new-console-template for more information
// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.
Console.WriteLine("Informe seu salario: ");
float salario = float.Parse ( Console.ReadLine ()!);
Console.WriteLine("Informe seu gasto total: ");
float gasto = float.Parse ( Console.ReadLine ()!);
if (gasto>salario) {
    Console.WriteLine("Orçamento estourado");
}
else {
     Console.WriteLine("Gastos dentro do orçamento");
}