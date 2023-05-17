namespace Projeto_login
{
    public class Produto
    {
        private int Codigo = 2222;
        private string NomeProduto = "chinelo";
        private float Preco = 2.35f;
        private DateTime DataCadastro;
        private Marca Marca;
        private Usuario CadastradoPor;

        List<Produto> ListaDeProdutos = new List<Produto>();
        Produto Prod = new Produto();

           public string Cadastrar() 
        {
        //    falta fazer o loop de rpetição para por mais intens de forma dinamica

            
            ListaDeProdutos.Add(Prod);
                       
            return $"Produto {Prod.NomeProduto} inserido com sucesso em  ";
            // tenho de olhar o esquema da data com mais calma

        }
        public string Deletar() 
        {
        //    falta fazer o loop de repetição para remover mais intens de forma dinamica
        // verificar como fzer o remove dinamico depois de testar
        // tem de criara a variavel que vai armazenar a escola a ser removida
        // tem fazer o find pra remover de acordo com a escolha do usuário
        ListaDeProdutos.Remove(Prod);
        // verificar a questão do produto no retorno e  a data que precisa ser a da remoção

            return $"Produto X removido com sucesso em XXXXXXXXX.";
        }

    public void Listar()
     {
        foreach (var Prod in ListaDeProdutos)
        {
            Console.WriteLine(@$"
            Codigo: {Prod.Codigo}
            Nome: {Prod.NomeProduto}
            ");
            // falta colocar os demais tens da lista para ser impresso com cwl vindo da marca.
            // preciso ver essa coisa da data pq a cada listagem ele vai dar data atual
            
        }        
     }

    }
    }