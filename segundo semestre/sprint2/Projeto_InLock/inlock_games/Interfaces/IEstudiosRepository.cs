
using inlock_games.Domains;

namespace inlock_games.Interfaces
{
    public interface IEstudiosRepository
    {
        List<EstudiosDomain> ListarTodos();
    }
}