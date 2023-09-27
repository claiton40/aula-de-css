using HealthClinic.Domains;

namespace HealthClinic.Interfaces
{
    public interface IAdminRepository
    {
        void Cadastrar(Admin admin);
        void Deletar(Guid id);
        List<Admin> Listar();
        Admin BuscarPorId(Guid id);
        void Atualizar(Guid id, Admin admin);
    }
}
