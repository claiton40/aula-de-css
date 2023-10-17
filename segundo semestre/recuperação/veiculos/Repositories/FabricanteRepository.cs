using veiculos.Contexts;
using veiculos.Domains;
using veiculos.Interfaces;

namespace veiculos.Repositories
{
    public class FabricanteRepository : IFabricanteRepository
    {
        /// <summary>
        /// este objeto acessa a classe contexto que, por sua vez, acessa o banco de dados
        /// </summary>
        Veiculos_Context ctx = new Veiculos_Context();

        public void Atualizar(Guid id, Fabricante fabricanteAtualizado)
        {
            throw new NotImplementedException();
        }

        public Fabricante BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Fabricante fabricante)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// lista todos os objeto da calssse Fabricante a partir de um objeto do contexto
        /// </summary>
        /// <returns>uma lista de fabricantes</returns>
        public List<Fabricante> Listar()
        {
            try
            {
                return ctx.Fabricante.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
