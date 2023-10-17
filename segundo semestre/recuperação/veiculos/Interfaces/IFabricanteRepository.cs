using veiculos.Domains;

namespace veiculos.Interfaces
{
    public interface IFabricanteRepository
    {
        void Cadastrar(Fabricante fabticante);
        List<Fabricante> Listar();
        Fabricante BuscarPorId(Guid id);
        void Atualizar(Guid id);
        void Deletar(Guid id);
        
    }
}
