using veiculos.Domains;

namespace veiculos.Interfaces
{
    public interface IVeiculoRepository
    {

        /// <summary>
        /// cadastra um novo veiculo
        /// </summary>
        /// <param name="veiculo"> um objeto da classe veiculo</param>
        void Cadastrar(Veiculo veiculo);

        /// <summary>
        /// lista todos os veiculos da tabela
        /// </summary>
        /// <returns> uma lista de veiculos</returns>
        List<Veiculo> Listar();

        /// <summary>
        /// busca um veiculo pelo seu ID
        /// </summary>
        /// <param name="id"> Id do veiculo buscado</param>
        /// <returns> o veiculo referente ao id buscado</returns>
        Veiculo BuscarPorId(Guid id);

        /// <summary>
        /// Atualizar um registro de veiculo
        /// </summary>
        /// <param name="id"> id do veiculo a ser buscado</param>
        /// <param name="veiculo"> veiculo com os dados atualizados</param>
        void Atualizar(Guid id, Veiculo veiculo);

        /// <summary>
        /// Deleta um registro da tabela
        /// </summary>
        /// <param name="id">id do veiculo a ser deletado</param>
        void Deletar(Guid id);
    }
}
