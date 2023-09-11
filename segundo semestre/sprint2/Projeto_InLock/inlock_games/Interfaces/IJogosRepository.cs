using inlock_games.Domains;

namespace inlock_games.Interfaces
{
    public interface IJogosRepository
    {

        List<JogosDomain> ListarTodos();
    }
}