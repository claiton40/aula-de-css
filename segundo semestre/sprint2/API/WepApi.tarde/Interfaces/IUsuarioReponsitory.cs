using WepApi.tarde.Domains;

namespace WepApi.tarde.Interfaces
{
    public interface IUsuarioReponsitory
    {
        UsuarioDomain Login (string Email, string Senha);
    }
}
