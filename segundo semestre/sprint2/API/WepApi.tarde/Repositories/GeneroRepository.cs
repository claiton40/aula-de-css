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

        public GeneroDomain BuscarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain NovoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int Id)
        {
            throw new NotImplementedException();
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
                using (SqlCommand cmd = new SqlCommand())
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
    }
}
