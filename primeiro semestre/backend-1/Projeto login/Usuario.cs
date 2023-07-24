namespace Projeto_login
{
    public class Usuario
    {
        public int Codigo {get; set;}
        public string Nome {get; set;} 
        public string Email {get; set;}
        public string Senha {get; set;} 
        public DateTime DataDeCadastro {get; set;}

        public Usuario()
        {
             Cadastrar();
        }
        public void Cadastrar() 
        {
            this.Codigo = 123;
            this.Nome= "jose das couves";
            this.Email = "jose@jose.com";
            this.Senha = "123";
            this.DataDeCadastro = DateTime.Now;
        }
    
        public string Deletar() 
        {
            this.Codigo = 0 ;
            this.Nome= "";
            this.Email = "";
            this.Senha = "";
            this.DataDeCadastro = DateTime.Parse("0000-00-00T00:00:00");
        

            return $"Usuario removido com sucesso em {DateTime.Now  } ";
        }
    

    }
   
}