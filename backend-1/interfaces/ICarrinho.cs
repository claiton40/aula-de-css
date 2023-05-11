namespace interfaces
{
    public interface ICarrinho
    {
        void Adicionar(Produto _produto);

        void Atualizar(int _codigo, Produto _produto);
        void Listar();

        void Remover(Produto _produto);       
    }
}