using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            try
            {
                _context.Clinica.Add(clinica);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Clinica> Listar()
        {
            try
            {
                return _context.Clinica.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
