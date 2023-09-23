using Event_.Domains;
using Event_.Interfaces;

namespace Event_.Repositories
{
    public class PresencaRepository : IPresencaEventoRepository
    {
        public void Atualizar(Guid id, PresencaEvento presencaEvento)
        {
            throw new NotImplementedException();
        }

        public PresencaEvento BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Inscrever(PresencaEvento inscricao)
        {
            throw new NotImplementedException();
        }

        public List<PresencaEvento> Listar()
        {
            throw new NotImplementedException();
        }

        public List<PresencaEvento> ListarMinhas(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
