namespace interfaces
{
    public class Produto
    {
        public int Codigo;
        public string Nome;
        public float Preco;

        public Produto(int codigo, string nome, float preco )
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}