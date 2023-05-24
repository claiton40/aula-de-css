namespace backend2.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float preco { get; set; }

    // caminho da pasta e do arquivi .csv
    private const string PATH= "Banco/Produto.csv";

    public Produto()
    {
        //Criar a logica para a gerara a pasta e o arquivo
        string pasta = PATH.Split("/")[0];
        if (!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }

        if (!File.Exists(PATH))
        {
            File.Create(PATH);
        }
    }
    public List<Produto> Ler(Produto p)
    {
        List<Produto> produtos = new List<Produto>();
        string[] linhas = {};

        
        return produtos;
    }

    public string PrepararLinhasCSV(Produto p)
    {
        return $"{p.Codigo}; {p.Nome}; {p.preco}";
    }
    // inserir
    public void Inserir(Produto p)
    {
        string[] linhas = {PrepararLinhasCSV(p)};
        File.AppendAllLines(PATH,  linhas);
    }


}
}