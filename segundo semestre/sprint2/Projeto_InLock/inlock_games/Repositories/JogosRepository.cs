using System;
using System.Data.SqlClient;
using inlock_games.Domains;
using inlock_games.Interfaces;

namespace inlock_games.Repositories
{
    public class JogosRepository : IJogosRepository
    {
        private string StringConexao = "Data Source = DESKTOP-B541VSR; Initial Catalog = Filmes; Integrated Security = true";



        public List<JogosDomain> ListarTodos()
        {
            List<JogosDomain> ListaJogos = new List<JogosDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectAll = "SELECT Jogo.IdJogo, Jogo.IdEstudio, Jogo.Nome, Estudio.Nome, Jogo.Descrocao, Jogo.Datalancamento, Jogo.Valor FROM Jogo INNER JOIN Estudio ON Jogo.IdEstudio = Estudio.IdEstudio";

    
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = SqlCommand(querySelectAll, con)) 
                {
                rdr= cmd.ExecuteReader();
                    while (rdr.Read()) 
                    {
                    JogosDomain Jogo = new JogosDomain()
                    {
                        IdJogo = Convert.ToInt32(rdr["IdJogo"]),

                        IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),

                        Nome = rdr["Nome"].ToString(),

                        Descricao = Convert.ToInt32(rdr["Descricao"]),


                    };

                    }
                }
            }
        }
    }
}