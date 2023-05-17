namespace Projeto_login
{
    
    public class Marca
    {
    
        public int Codigo = 222;
        public string NomeMarca= "Pakalolo";
        public DateTime Data = DateTime.UtcNow;

  List<Marca> marca = new List<Marca>();
  Marca m = new Marca();
        public string Cadastrar() 
        {
        
        }
        public string Deletar() 
        {
            return $"Marca X removida com sucesso em {m.Data}.";
        }

    public void Listar()
     {
              
     }

    }
   
}