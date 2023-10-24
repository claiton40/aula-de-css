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
        /// <summary>
        /// Cadastra um novo veiculo
        /// </summary>
        /// <param name="veiculo">dados do objeto veiculo</param>
        public void Cadastrar(Veiculo veiculo)
        {
            ctx.Veiculo.Add(veiculo);

            ctx.SaveChanges(); 
        }

        /// <summary>
        /// Deletar um veiculo do bancoi de dados
        /// </summary>
        /// <param name="id">O id do veiculo a ser apagado</param>
        public void Deletar(Guid id)
        {
            try
            {
               Veiculo veiculoBuscado = ctx.Veiculo.Find(id)!;

                if (veiculoBuscado != null)
                {
                    ctx.Veiculo.Remove(veiculoBuscado);

                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Lista todos os veiculos da base
        /// </summary>
        /// <returns>Uma lsita com todos os veiculos da base</returns>
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
