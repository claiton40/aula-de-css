using webapi.inlock.tarde.Domains;

namespace webapi.inlock.tarde.Interface
{
    public interface IEstudioRepository
    {
        List<Estudio> Listar();
        Estudio BuscarPorId(Guid id);
        Estudio BuscarPorId(Estudio estudio);
        void Atualizar(Guid id);
        void Deletar(Guid Id);
        List<Estudio> ListraComJogos();
    }
}
