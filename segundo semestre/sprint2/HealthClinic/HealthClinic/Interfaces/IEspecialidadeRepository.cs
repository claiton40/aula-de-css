using HealthClinic.Domains;

namespace HealthClinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);
        List<Especialidade> Listar();
        Especialidade BuscarPorId(Guid id);
    }
}
