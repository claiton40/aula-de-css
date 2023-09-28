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
            try
            {
                Admin adminBuscado = _context.Admin
                    .Select(u => new Admin
                    {
                        IdAdmin = u.IdAdmin,
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,

                    }).FirstOrDefault(u => u.IdAdmin == id)!;

                if (adminBuscado != null)
                {
                    return adminBuscado;

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
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
