namespace fyncao_list
{
    public class Produto
    {
        public int Codigo;
        public string Nome;
        public double Preco;

        public Produto()
        {

        }
        public Produto(int codigo,
         string nome,
         double preco)
         {
            Nome=nome;
            Codigo=codigo;
            Preco=preco;
         }

    }
}