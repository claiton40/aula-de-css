using WepApi.tarde.Domains;

namespace WepApi.tarde.Interfaces
{
    /// <summary>
    /// Responsavel pelo repositorio GeneroRepository
    /// Define os metodos que serao implemenetados pelo respositorio
    /// </summary>
    public interface IGeneroRepository
    {
        //CRUD

        //TipoDeRetorno Nomedometodo (TipoParamentro NomeParamentro)

        /// <summary>
        /// Cadastrar novo genero
        /// </summary>
        /// <param name="NovoGenero">Objeto que sera cadastrado</param>
        void Cadastrar(GeneroDomain NovoGenero);

        /// <summary>
        /// Retornar todos os generos cadastrados
        /// </summary>
        /// <returns> Lista de Generos</returns>
        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Buscar Obejeto poer Id
        /// </summary>
        /// <param name="Id">Objeto que foi buscado</param>
        /// <returns></returns>
        GeneroDomain BuscarPorId(int Id);

        /// <summary>
        /// Atualizar um genero existente passando o Id pelo corpo da requisicao
        /// </summary>
        /// <param name="Genero"> Objeto com as novas informacoes</param>
        void AtualizarIdCorpo(GeneroDomain Genero);
        /// <summary>
        /// Atualizar um genero existente passando id pela url da requisicao
        /// </summary>
        /// <param name="id">Id do Objeto a ser atualizado</param>
        /// <param name="Genero">Objeto com as novas informacoes</param>
        void AtualizarIdURL(int id, GeneroDomain Genero);

        /// <summary>
        /// Deletar um genero existente
        /// </summary>
        /// <param name="Id">Id do Objeto a ser deletado</param>
        void Deletar(int Id);
    }
}
