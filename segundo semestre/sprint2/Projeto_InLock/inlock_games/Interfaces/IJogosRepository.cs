using inlock_games.Domains;

namespace inlock_games.Interfaces
{
    public interface IJogosRepository
    {
         void Cadastrar(JogosDomain NovoJogo);

        List<JogosDomain> ListarTodos();
    }
}