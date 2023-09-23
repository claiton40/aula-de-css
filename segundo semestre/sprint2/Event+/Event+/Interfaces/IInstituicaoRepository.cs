using Event_.Domains;

namespace Event_.Interfaces
{
    public interface IInstituicaoRepository
    {
        void Cadastrar(Instituicao instituicao);
        void Deletar(Guid id);
        List<Instituicao> Listar();
        Instituicao BuscarPorId(Guid id);
        void Atualizar(Guid id, Instituicao instituicao);
    }
}
