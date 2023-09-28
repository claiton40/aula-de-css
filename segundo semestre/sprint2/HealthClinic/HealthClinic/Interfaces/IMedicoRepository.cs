using HealthClinic.Domains;

namespace HealthClinic.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);
        List<Medico> Listar();
        Medico BuscarPorId(Guid id)
    }
}
