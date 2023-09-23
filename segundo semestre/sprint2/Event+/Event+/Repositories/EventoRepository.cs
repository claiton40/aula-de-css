using Event_.Domains;
using Event_.Interfaces;

namespace Event_.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        void IEventoRepository.Atualizar(Guid id, Evento evento)
        {
            throw new NotImplementedException();
        }

        Evento IEventoRepository.BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        void IEventoRepository.Cadastrar(Evento evento)
        {
            throw new NotImplementedException();
        }

        void IEventoRepository.Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        List<Evento> IEventoRepository.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
