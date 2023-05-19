namespace projeto_marcas
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        // public Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        
        List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            
        }

        public void Listar()
        {
        
        }
        public void Deletar()
        {
        
        }

    }
}