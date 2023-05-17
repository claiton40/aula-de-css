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
        //    falta fazer o loop de rpetição para por mais intens de forma dinamica

            
            marca.Add(m);
            // Console.WriteLine($"Insira o Codigo da Marca{m.Codigo}");
            // // m.Codigo = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Insira o nome da Marca {m.NomeMarca}");
            // // m.NomeMarca= Console.ReadLine();
            // Console.WriteLine($"Data do cadastro{m.Data}");
                       
            return $"Marca {m.marca} inserida com sucesso em {m.Data} ";
        }
        public string Deletar() 
        {
            //    falta fazer o loop de rpetição para remover mais intens de forma dinamica
        // verificar como fzer o remove dinamico depois de testar
        marca.Remove(m);

          
          
    
            
            return $"Marca X removida com sucesso em {m.Data}.";
        }

    public void Listar()
     {
        foreach (var m in marca)
        {
            Console.WriteLine(@$"
            Codigo: {m.Codigo}
            Maraa: {m.marca}
            Data do cadastro: {m.Data}");
            // preciso ver essa coisa da data pq a cada listagem ele vai dar data atual
            
        }        
     }

    }
   
}