using Microsoft.EntityFrameworkCore;
using webapi.inlock.tarde.Contexts;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interface;

namespace webapi.inlock.tarde.Repository
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext Ctx = new InLockContext();

        public void Atualizar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Estudio BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Estudio BuscarPorId(Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Estudio estudio)
        {
            Ctx.Estudios.Add(estudio);

            Ctx.SaveChanges();
        }

        public void Deletar(Guid Id)
        {
            Estudio estudioBuscado = Ctx.Estudios.Find(Id);

            if (estudioBuscado != null)
            {
                Ctx.Estudios.Remove(estudioBuscado);
            }

            Ctx.SaveChanges();
        }

        public List<Estudio> Listar()
        {
            return Ctx.Estudios.ToList();

            
        }

        public List<Estudio> ListraComJogos()
        {
            return Ctx.Estudios.Include(e => e.Jogos).ToList();
        }
    }
}
