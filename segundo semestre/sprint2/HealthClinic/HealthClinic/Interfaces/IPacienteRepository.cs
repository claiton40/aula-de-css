using HealthClinic.Domains;

namespace HealthClinic.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);
        List<Paciente> Listar();
        Paciente BuscarPorId(Guid id);
    }
}
