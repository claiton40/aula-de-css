using System.Data.SqlClient;
using WepApi.tarde.Domains;
using WepApi.tarde.Interfaces;

namespace WepApi.tarde.Repositories
{
    public class UsuarioRepository : IUsuarioReponsitory
    {
        private string StringConexao = "Data Source = note01-s14; Initial Catalog= Filmes_Teste; User id = sa; Pwd = Senai@134";
        public UsuarioDomain Login(string Email, string Senha)
        {
            using (SqlConnection Con = new SqlConnection(StringConexao))
            {

                string QueryLogin = "Select IdUsuario, Email, Permissao from Usuario where Email = @email and Senha = @Senha";
                Con.Open();

                using (SqlCommand cmd = new SqlCommand(QueryLogin, Con))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),
                            Email = rdr["Email"].ToString(),
                            Permissao = rdr["Permissao"].ToString()
                        };
                        return usuario;
                    };
                }
                return null;
            }
        }
    }
}
