using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Interfaces;

namespace HealthClinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthClinic_Context _context;
        public ConsultaRepository()
        {
            _context = new HealthClinic_Context();
        }
        public Consulta BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> Listar()
        {
            throw new NotImplementedException();
        }

        public void Prontuario(Paciente paciente)
        {
            throw new NotImplementedException();
        }
    }
}
