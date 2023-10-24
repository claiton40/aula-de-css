using Microsoft.EntityFrameworkCore;
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

        /// <summary>
        /// Busca fabricante pro id
        /// </summary>
        /// <param name="id"> id do fabricante buscado</param>
        /// <returns>fabricante do id informado</returns>
        public Fabricante BuscarPorId(Guid id)
        {
            try
            {
                return ctx.Fabricante.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Cadastra um novo fabricante na base
        /// </summary>
        /// <param name="fabricante">dados para o objeto fabricante</param>
        public void Cadastrar(Fabricante fabricante)
        {
            try
            {
                ctx.Fabricante.Add(fabricante);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Deleta um fabricante da base
        /// </summary>
        /// <param name="id">id do fabricante a ser apagado</param>
        public void Deletar(Guid id)
        {
            try
            {

                Fabricante fabricanteBuscado = ctx.Fabricante.Find(id)!;
                
                    if (fabricanteBuscado != null)
                    {
                        ctx.Fabricante.Remove(fabricanteBuscado);
                    }

                    ctx.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
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
