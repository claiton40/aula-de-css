using inlock_games.Domains;

namespace inlock_games.Interfaces
{
    public interface IUsuariosRepository
    {
        UsuariosDomain Login(string email, string senha);

    }
}
