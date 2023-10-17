using veiculos.Domains;

namespace veiculos.Interfaces
{
    public interface IFabricanteRepository
    {
        /// <summary>
        /// Cadastra um fabricante novo
        /// </summary>
        /// <param name="fabricante"> objeto a ser cadastrado</param>
        void Cadastrar(Fabricante fabricante);

        /// <summary>
        /// listar todos os fabricantes
        /// </summary>
        /// <returns> lista de fabricantes</returns>
        List<Fabricante> Listar();

        /// <summary>
        /// busca fabricante pelo ID
        /// </summary>
        /// <param name="id"> ID do fabricante a ser buscado</param>
        /// <returns> retorna o fabricante buscado</returns>
        Fabricante BuscarPorId(Guid id);

        /// <summary>
        /// Atualiza um dos fabricantes
        /// </summary>
        /// <param name="id"> id do fobricante</param>
        /// <param name="fabricanteAtualizado">objeto com as novas informacoes</param>
        void Atualizar(Guid id, Fabricante fabricanteAtualizado);

        /// <summary>
        /// deleta um objeto a partir do id
        /// </summary>
        /// <param name="id"> id do objeto a ser deletado</param>
        void Deletar(Guid id);
        
    }
}
