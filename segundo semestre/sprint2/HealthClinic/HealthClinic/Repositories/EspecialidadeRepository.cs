using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Interfaces;

namespace HealthClinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthClinic_Context _context;
        public EspecialidadeRepository()
        {
            _context = new HealthClinic_Context();
        }
        public Especialidade BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Especialidade especialidade)
        {
            throw new NotImplementedException();
        }

        public List<Especialidade> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
