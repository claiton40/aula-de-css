using System.Data.SqlClient;
using inlock_games.Domains;
using inlock_games.Interfaces;

namespace inlock_games.Repositories
{
    public class TiposUsuariosRepository: ITiposUsuariosRepository
    {
         List<TiposUsuariosDomain> ListarTodos();
    }
}