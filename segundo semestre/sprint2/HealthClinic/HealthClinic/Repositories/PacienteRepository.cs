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
            try
            {
                return _context.Paciente.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Paciente paciente)
        {
            try
            {
                _context.Paciente.Add(paciente);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Paciente> Listar()
        {
            try
            {
                return _context.Paciente.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
