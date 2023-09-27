using HealthClinic.Domains;

namespace HealthClinic.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);
        List<Clinica> Listar();
        
    }
}
