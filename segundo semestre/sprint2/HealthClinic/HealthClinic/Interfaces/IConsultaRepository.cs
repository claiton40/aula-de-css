using HealthClinic.Domains;

namespace HealthClinic.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);
        void Deletar(Guid id);
        List<Consulta> Listar();
        Consulta BuscarPorId(Guid id);
        void Prontuario(Guid id, string consulta);
    }
}
