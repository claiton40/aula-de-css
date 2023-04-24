using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 
// // VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

namespace sitema_de_medias_de_notas
{
    
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public int rg;
        public bool bolsista;
        public Double mediafinal;
        public Double valormensalidade;
    
public Double VerMediaFinal()
{
return mediafinal;
}
public Double VerMensalidade()
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
{
    if(bolsista=true)
    {
        
if (mediafinal>=8){
     valormensalidade=(valormensalidade/2);
}
else if(mediafinal>6)
{
 valormensalidade=(valormensalidade/0.70);
}
}
return valormensalidade;
    }
}
}