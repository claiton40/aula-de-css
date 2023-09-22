using Event_.Domains;

namespace Event_.Interfaces
{
    public interface ITipoEventoRepository
    {
        void Cadastrar(TipoEvento tipoEvento);

        void Deletar(Guid id);

        List<TipoEvento> Listar();
    }
}
