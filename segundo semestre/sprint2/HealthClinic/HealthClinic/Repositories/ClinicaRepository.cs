using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Interfaces;

namespace HealthClinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthClinic_Context _context;
        public ClinicaRepository()
        {
            _context = new HealthClinic_Context();
        }
        public void Cadastrar(Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public List<Clinica> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
