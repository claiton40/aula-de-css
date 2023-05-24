namespace projeto_marcas
{
    public class Usuario
    {
       public int Codigo { get; set; } 
       public string Nome { get; set; }
       public string Email { get; set; }
       public string Senha { get; set; }
       public DateTime DataCadastro { get; set; }

       public static List<Usuario> ListaDeUsuario = new List<Usuario>();

       public void Cadastrar()
       {
        Usuario NovoUsuario = new Usuario();
        ListaDeUsuario.Add(NovoUsuario);
        NovoUsuario.Codigo = 123;
        NovoUsuario.Nome= "Jose das Couves";
        NovoUsuario.Email= "jose@dascouves.org";
        NovoUsuario.Senha="1234";


       }
       public void Deletar()
       {
         Usuario NovoUsuario = new Usuario();
        ListaDeUsuario.Remove(NovoUsuario);
       }
    }
}

