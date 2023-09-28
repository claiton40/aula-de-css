using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Interfaces;

namespace HealthClinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthClinic_Context _context;
        public MedicoRepository()
        {
            _context = new HealthClinic_Context();
        }
        public Medico BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Medico medico)
        {
            throw new NotImplementedException();
        }

        public List<Medico> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
