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



        public void Prontuario(Guid id, string descricaoConsulta)
        {
            try
            {

                Consulta consultaBuscada = _context.Consulta
                    .Select(c => new Consulta
                    {
                        IdConsulta= c.IdConsulta,
                        IdMedico= c.IdMedico,
                        Data = c.Data,
                        IdPaciente= c.IdPaciente,
                        Paciente = new Paciente
                        {
                            IdPaciente= c.Paciente!.IdPaciente,
                            Descricao = c.Paciente!.Descricao,
                            Email = c.Paciente!.Email,
                            Nome = c.Paciente.Nome,
                            Senha = c.Paciente.Senha,
                        }
                    })
                    .FirstOrDefault(c => c.IdConsulta == id)!;

                if (consultaBuscada != null)
                {
                    consultaBuscada.IdConsulta = consultaBuscada.IdConsulta;
                    consultaBuscada.IdMedico = consultaBuscada.IdMedico;
                    consultaBuscada.Data = consultaBuscada.Data;
                    consultaBuscada.IdPaciente = consultaBuscada.IdPaciente;

                    
                    consultaBuscada.Paciente!.Descricao = descricaoConsulta;
                }

                _context.Consulta.Update(consultaBuscada!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}

//HttpPatch