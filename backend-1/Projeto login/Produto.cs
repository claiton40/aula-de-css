namespace Projeto_login
{
    public class Produto
    {
        private int Codigo;
        private string NomeProduto;
        private float Preco;
        private DateTime DataCadastro;
        private Marca Marca;
        private Usuario CadastradoPor;

        List<Produto> ListaDeProdutos = new List<Produto>();
        Produto Prod = new Produto();

           public string Cadastrar() 
        {
        
        }
        public string Deletar() 
        {
           return $"Produto X removido com sucesso em XXXXXXXXX.";
        }

    public void Listar()
     {
      
     }        
     }

    }
    