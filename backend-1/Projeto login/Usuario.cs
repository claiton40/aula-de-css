namespace Projeto_login
{
    public class Usuario
    {
        public int Codigo;
        public string Nome;
        public string Email;
        public string Senha;

        private DateTime DataDeCadastro = DateTime.Now;

        List<Usuario> ListaDeUsuarios = new List<Usuario>()
         Usuario User = new Usuario();
        public string Cadastrar() 
        {
            User.Codigo = 123
            User.Nome= "jose das couves";
            User.Email = "jose@jose.com";
            User.Senha = "123";
            User.DataDeCadastro = DateTime.Now;
        

            return $"Usuario {User.Nome} inserida com sucesso em XXXXXXXXXXXXX ";
        }
    

    }
   
}