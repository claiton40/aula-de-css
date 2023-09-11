using System.Data.SqlClient;
using inlock_games.Domains;
using inlock_games.Interfaces;

namespace inlock_games.Repositories
{
    public class EstudiosRepository : IEstudiosRepository
    {

        private string StringConexao = "Data Source = note01-s14; Initial Catalog= Filmes_Teste; User id = sa; Pwd = Senai@134";

        public List<EstudiosDomain> ListarTodos()
        {
            List<EstudiosDomain> ListaEstudio = new List<EstudiosDomain>();
            using (SqlConnection con = new SqlConnection(StringConexao)) 
            {
                string querySelectAll = "select Estudio.IdEstudio, Estudio.Nome from Estudio";
                con.Open();
                SqlDataReader rdr;
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                rdr= cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        EstudiosDomain Estudio = new EstudiosDomain()
                        {
                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),
                            Nome = rdr["Nome"].ToString(),
                        };
                        ListaEstudio.Add(Estudio);
                    }
                }
            }
            return ListaEstudio;
        }
    }
}