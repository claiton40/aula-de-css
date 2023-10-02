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
            try
            {
                return _context.Especialidade.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Especialidade especialidade)
        {
            try
            {
                _context.Especialidade.Add(especialidade);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Especialidade> Listar()
        {
            try
            {
                return _context.Especialidade.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
