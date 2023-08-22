using WepApi.tarde.Domains;

namespace WepApi.tarde.Interfaces
{
    // <summary>
    /// Responsavel pelo repositorio FilmeRepository
    /// Define os metodos que serao implemenetados pelo respositorio
    /// </summary>
    public interface IFilmeRepository
    {
        //CRUD

        //TipoDeRetorno Nomedometodo (TipoParamentro NomeParamentro)

        /// <summary>
        /// Cadastrar novo genero
        /// </summary>
        /// <param name="NovoFilme">Objeto que sera cadastrado</param>
        void Cadastrar(FilmeDomain NovoFilme);

        /// <summary>
        /// Retornar todos os Filmes cadastrados
        /// </summary>
        /// <returns> Lista de Filmes</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        /// Buscar Objeto por Id
        /// </summary>
        /// <param name="Id">Objeto que foi buscado</param>
        /// <returns></returns>
        FilmeDomain BuscarPorId(int Id);

        /// <summary>
        /// Atualizar um Filme existente passando o Id pelo corpo da requisicao
        /// </summary>
        /// <param name="Filme"> Objeto com as novas informacoes</param>
        void AtualizarIdCorpo(FilmeDomain Filme);
        /// <summary>
        /// Atualizar um Filme existente passando id pela url da requisicao
        /// </summary>
        /// <param name="id">Id do Objeto a ser atualizado</param>
        /// <param name="Filme">Objeto com as novas informacoes</param>
        void AtualizarIdURL(int id, FilmeDomain Filme);

        /// <summary>
        /// Deletar um genero existente
        /// </summary>
        /// <param name="Id">Id do Objeto a ser deletado</param>
        void Deletar(int Id);
    }
}
