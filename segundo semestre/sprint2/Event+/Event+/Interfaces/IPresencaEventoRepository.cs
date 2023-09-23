using Event_.Domains;

namespace Event_.Interfaces
{
    public interface IPresencaEventoRepository
    {
        void Deletar(Guid id);
        List<PresencaEvento> Listar();
        PresencaEvento BuscarPorId(Guid id);
        void Atualizar(Guid id, PresencaEvento presencaEvento);
        List<PresencaEvento> ListarMinhas(Guid id);
        void Inscrever(PresencaEvento inscricao);
    }
}
