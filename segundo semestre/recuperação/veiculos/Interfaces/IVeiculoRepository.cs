using veiculos.Domains;

namespace veiculos.Interfaces
{
    public interface IVeiculoRepository
    {
        void Cadastrar(Veiculo veiculo);
        List<Veiculo> Listar();
        Veiculo BuscarPorId(Guid id);
        void Atualizar(Guid id, Veiculo veiculo);
        void Deletar(Guid id);
    }
}
