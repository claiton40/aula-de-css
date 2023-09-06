using System.Data.SqlClient;
using inlock_games.Domains;
using inlock_games.Interfaces;

namespace inlock_games.Repositories
{
    public class JogosRepository : IJogosRepository
    {
        public void Cadastrar(JogosDomain NovoJogo)
        {
            throw new NotImplementedException();
        }

        public List<JogosDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}