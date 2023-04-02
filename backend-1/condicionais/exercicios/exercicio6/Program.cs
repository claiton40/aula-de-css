// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.
Console.WriteLine("insira a média");
int media = int.Parse (Console.ReadLine());
Console.WriteLine("insira as presenças");
int freq = int.Parse (Console.ReadLine());
int totalfreq = (100);
if (freq>totalfreq){
    Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("frequência invalida");
}
else if (freq<75 | media<3){
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Aluno reprovado!");
Console.ResetColor();
}

else if (media<=7) {
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("Aluno de recuperação!");
Console.ResetColor();
}

else {
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine ("Aluno aprovado!!");
Console.ResetColor();
}