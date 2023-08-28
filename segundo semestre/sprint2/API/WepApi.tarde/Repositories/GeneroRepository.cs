using System.Data.SqlClient;
using WepApi.tarde.Domains;
using WepApi.tarde.Interfaces;

namespace WepApi.tarde.Repositories
{
    /// <summary>
    /// classe responsavel pelo repositorio de generos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// Sntring de conexao com o banco de dados recebe os seguintes parametros
        /// Data Source - Nome do Servidor Banco de dados
        /// Initial Catalog - Nome do Banco de dados
        /// Autenticacao:
        ///             User - sa
        ///             Pwd - Senai@134
        /// </summary>
        private string StringConexao = "Data Source = note01-s14; Initial Catalog= Filmes_Teste; User id = sa; Pwd = Senai@134";
        public void AtualizarIdCorpo(GeneroDomain Genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdURL(int id, GeneroDomain Genero)
        {
            throw new NotImplementedException();
        }

        


        /// <summary>
        /// Cadastrar genero
        /// </summary>
        /// <param name="NovoGenero">Objeto com as informacoes cadastradas</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Cadastrar(GeneroDomain NovoGenero)
        {
            using (SqlConnection Con = new SqlConnection(StringConexao))
            {
                //Declara a query q sera executada
                string QueryInsert = "insert into Genero (Nome) values (' " + NovoGenero.Nome + "')";

                //declara o SQLCommand passando a Query que sera execultado e a conexao com o bd
                using (SqlCommand cmd = new SqlCommand(QueryInsert, Con))
                {
                    //Abre a conexao com o banco de dados
                    Con.Open();

                    ///Executa a Query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// deletar um genero
        /// </summary>
        /// <param name="Id">genero a ser deletado</param>
        public void Deletar(int Id)
        {

            using (SqlConnection Con = new SqlConnection(StringConexao))
            {
                string QueryDelete = "delete from Genero where IdGenro = @idGenero";

                //declara o SQLCommand passando a Query que sera execultado e a conexao com o bd
                using (SqlCommand cmd = new SqlCommand(QueryDelete, Con))
                {
                    //Abre a conexao com o banco de dados
                    Con.Open();

                    cmd.Parameters.AddWithValue("@idGenero", Id);

                    ///Executa a Query
                    cmd.ExecuteNonQuery();
                }
            }

        }

        

        /// <summary>
        /// Listar todos os objetos do tipo Genero
        /// </summary>
        /// <returns> Lista de Objetos do tipo Genero </returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<GeneroDomain> ListarTodos()
        {
            //cria uma lista de generos onde serao armazenados os generos
            List<GeneroDomain> ListaGenero = new List<GeneroDomain>();

            //Declara a SQL conectio passsando a string de conexao como parametro
            using (SqlConnection Con = new SqlConnection(StringConexao))
            {
                //Declara a isntrucao a ser executada
                string Consulta = "select IdGenero, Nome from Genero";
                //Abre a conexao com o banco de dados
                Con.Open();
                //declara o SQL data reader para percorrer a tabela do banco de dados
                SqlDataReader Leitor;
                //declara o sqlCommand passan do a Query que sera execultada e a conexao
                using (SqlCommand cmd = new SqlCommand(Consulta, Con))
                {

                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        GeneroDomain Genero = new GeneroDomain()
                        {
                            //atribui a prppriedade id genero o valor da primeira coluna da tabela
                            IdGenero = Convert.ToInt32(Leitor[0]),
                            //Atribui a proprieade Nmome o Valor da coluna Nome
                            Nome = Leitor["Nome"].ToString(),
                        };
                        // Adiciona Objeto Criado dentro da lista
                        ListaGenero.Add(Genero);
                    }
                }
            }
            //Retorna a lista de generos
            return ListaGenero;
        }

        /// <summary>
        /// procura por id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public GeneroDomain BuscarPorId(int Id)
        {
            using (SqlConnection Con = new SqlConnection(StringConexao))
            {
                //Declara a isntrucao a ser executada
                string Consulta = "select IdGenero, Nome from Genero Where IdGenero @IdGenero";
                //Abre a conexao com o banco de dados
                Con.Open();
                SqlDataReader Leitor;
                //declara o sqlCommand passan do a Query que sera execultada e a conexao
                using (SqlCommand cmd = new SqlCommand(Consulta, Con))
                {

                    Leitor = cmd.ExecuteReader();

                    if (Leitor.Read())
                    {
                        GeneroDomain GeneroBuscado = new GeneroDomain()
                        {
                            //atribui a prppriedade id genero o valor da primeira coluna da tabela
                            IdGenero = Convert.ToInt32(Leitor["IdGenero"]),
                            //Atribui a proprieade Nmome o Valor da coluna Nome
                            Nome = Leitor["Nome"].ToString(),
                        };
                        // Adiciona Objeto Criado dentro da lista
                        return GeneroBuscado;
                    }
                    return null;
                }
            }
   
        }
    }
}
