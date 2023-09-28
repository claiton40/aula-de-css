using HealthClinic.Domains;

namespace HealthClinic.Interfaces
{
    public interface IAdminRepository
    {
        void Cadastrar(Admin admin);
        List<Admin> Listar();
        Admin BuscarPorId(Guid id);
    }
}
