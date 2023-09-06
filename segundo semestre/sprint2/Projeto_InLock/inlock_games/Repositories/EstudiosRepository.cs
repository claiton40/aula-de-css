using System.Data.SqlClient;
using inlock_games.Domains;
using inlock_games.Interfaces;

namespace inlock_games.Repositories
{
    public class EstudiosRepository: IEstudiosRepository
    {
        private string StringConexao = "Data Source = note01-s14; Initial Catalog= Filmes_Teste; User id = sa; Pwd = Senai@134";
        
        public void Cadastrar(EstudiosDomain NovoEstudio);

        List<EstudiosDomain> ListarTodos();
    }
}