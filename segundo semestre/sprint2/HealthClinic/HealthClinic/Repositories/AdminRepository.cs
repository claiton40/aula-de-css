using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Interfaces;

namespace HealthClinic.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly HealthClinic_Context _context;

        public AdminRepository()
        {
            _context = new HealthClinic_Context();
        }
        public Admin BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Admin admin)
        {
            throw new NotImplementedException();
        }

        public List<Admin> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
