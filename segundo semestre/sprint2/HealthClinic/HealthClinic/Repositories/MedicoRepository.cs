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
            try
            {
                return _context.Medico.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Medico medico)
        {
            try
            {
                _context.Medico.Add(medico);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Medico> Listar()
        {
            try
            {
                return _context.Medico.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
