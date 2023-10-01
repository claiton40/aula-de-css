using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Interfaces;
using HealthClinic.Utils;

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
            try
            {

                admin.Senha = Criptografia.GerarHash(admin.Senha!);


                _context.Admin.Add(admin);


                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Admin> Listar()
        {
            try
            {
                return _context.Admin.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
