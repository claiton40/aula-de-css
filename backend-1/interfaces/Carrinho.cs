namespace interfaces
{
    public class Carrinho : ICarrinho
    {
        float Valor;
        List<Produto> carrinho = new List<Produto>();
        public void Adicionar(Produto _produto)
        {
             carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoproduto)
        {
            carrinho.Find(X=>X.Codigo == _codigo).Nome = _novoproduto.Nome;
        }

        public void Listar()
        {
            foreach(Produto p in carrinho)
            {
                Console.WriteLine(@$"
                Nome: {p.Nome}
                Codigo: {p.Codigo}
                Preco: {p.Preco}");
                
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void TotaCarrinho(){
            Valor = 0;
            
            if (Valor >0)
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }
                Console.WriteLine($"O total e {Valor}");
                
            }
        }
    }
}