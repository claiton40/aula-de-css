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
            try
            {
                return _context.Consulta.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Consulta consulta)
        {
            try
            {
                _context.Consulta.Add(consulta);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Consulta consultaBuscada = _context.Consulta.Find(id)!;

                if (consultaBuscada != null)
                {
                    _context.Consulta.Remove(consultaBuscada);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Consulta> Listar()
        {
            try
            {
                return _context.Consulta.ToList();
            }
            catch (Exception)
            {
                throw; 
            }
        }

       

        public void Prontuario(Paciente paciente)
        {
            try
            {
                Paciente pacienteBuscado = _context.Paciente.!;

                if (pacienteBuscado != null)
                {
                    pacienteBuscado.Descricao = pacienteBuscado.Descricao;
                }

                _context.TipoUsuario.Update(tipoBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
