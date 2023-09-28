using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Interfaces;

namespace HealthClinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthClinic_Context _context;
        public PacienteRepository()
        {
            _context = new HealthClinic_Context();
        }
        public Paciente BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
