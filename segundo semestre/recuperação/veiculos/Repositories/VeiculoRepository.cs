using veiculos.Contexts;
using veiculos.Domains;
using veiculos.Interfaces;

namespace veiculos.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {

        /// <summary>
        /// este objeto acessa a classe contexto que, por sua vez, acessa o banco de dados
        /// </summary>
        Veiculos_Context ctx = new Veiculos_Context();

        public void Atualizar(Guid id, Veiculo veiculo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// busca um veiculo por id
        /// </summary>
        /// <param name="id">informa o id do veiculo buscado</param>
        /// <returns> O Veiculo referente ao ID buscado</returns>
        public Veiculo BuscarPorId(Guid id)
        {
            try
            {
                return ctx.Veiculo.Find(id);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Cadastrar(Veiculo veiculo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Veiculo> Listar()
        {

            try
            {
                return ctx.Veiculo.ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
