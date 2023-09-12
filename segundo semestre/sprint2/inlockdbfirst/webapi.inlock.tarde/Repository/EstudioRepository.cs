using webapi.inlock.tarde.Contexts;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interface;

namespace webapi.inlock.tarde.Repository
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext Ctx = new InLockContext();

        void IEstudioRepository.Atualizar(Guid id)
        {
            throw new NotImplementedException();
        }

        Estudio IEstudioRepository.BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        Estudio IEstudioRepository.BuscarPorId(Estudio estudio)
        {
            throw new NotImplementedException();
        }

        void IEstudioRepository.Deletar(Guid Id)
        {
            throw new NotImplementedException();
        }

        List<Estudio> IEstudioRepository.Listar()
        {
            return Ctx.Estudios.ToList();
        }

        List<Estudio> IEstudioRepository.ListraComJogos()
        {
            throw new NotImplementedException();
        }
    }
}
