
using inlock_games.Domains;

namespace inlock_games.Interfaces
{
    public interface IEstudiosRepository
    {
        void Cadastrar(EstudiosDomain NovoEstudio);

        List<EstudiosDomain> ListarTodos();
    }
}