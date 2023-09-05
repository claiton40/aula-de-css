using inlock_games.Domains;

namespace inlock_games.Interfaces
{
    public interface ITiposUsuariosRepository
    {
        //void Cadastrar(TiposUsuariosDomain NovoTipoUsuario);

        List<TiposUsuariosDomain> ListarTodos();
    }
}
