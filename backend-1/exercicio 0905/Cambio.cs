//  Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)
namespace exercicio_0905
{
    public static class Cambio
    {
        public static double Valor { get; set; }
        public static double ValorCambio { get; set; }
        public static double DolarReal(double Dolar)
        {
            return Valor * ValorCambio;
          
            
             
        }
         public static double RealDolar(double Real)
        {
            return  Valor / ValorCambio;
            
             
        }

    }
       

    
}