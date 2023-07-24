namespace backend2.Model
{
    public class Produto
    {
        // atributos da classe
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

    // caminho da pasta e do arquivo .csv (base de dados)
    private const string PATH= "Banco/Produto.csv";

// criando metodo construtor do produto
    public Produto()
    {
        //definindo o delimitador de campos do arquivo .csv (banco de dados)
        string pasta = PATH.Split("/")[0];
        // verificando se a pasta para o .csv existe
        if (!Directory.Exists(pasta))
        {
            // caso nao exista, criar.
            Directory.CreateDirectory(pasta);
        }
        // verificando se o arquivo .csv para o .csv existe. Como pressupomos a exitencia da pasta, samos o caminho completo
        if (!File.Exists(PATH))
        {
            // caso nao exista, criar.
            File.Create(PATH);
        }
    }
    // metodo para tirar dados do .csv e jogar em um objeto
    public List<Produto> Ler()
    {
        // criando lista de objetos Produto para receber os dados do .csv
        List<Produto> produtos = new List<Produto>();
        // criando array de strings para tirar linhas do .csv
        string[] linhas = File.ReadAllLines(PATH);
        // foreach para colocar strings em um objeto para por no List.
        foreach (var item in linhas)
        {
            // criando array para splitar os itens do array "linhas".
            string[] atributos = item.Split(";");
            // istanciando objeto para recebr resutados do split
            Produto p = new Produto();
            // colocando cada string splitada nos atributos do objeto do tipo Produto
            p.Codigo = int.Parse(atributos[0]);
            p.Nome = atributos[1];
            p.Preco = float.Parse(atributos[2]);
            // adicionando o objeto para a lista produtos
            produtos.Add(p);
        } 
        //o metdodo retorna a lista produtos com o objeto p com os dados do array splitados     
        return produtos;
    }
    // metodo para preparar linhas para jogar dados digitados na view no .csv
    public string PrepararLinhasCSV(Produto p)
    {
        return $"{p.Codigo};{p.Nome};{p.Preco}";
    }
    // metodo para para jogar dados digitados no .csv
    public void Inserir(Produto p)
    {
        // criando array de para receber os dados digitados chamando o metodo de cima que vai formatar os dados.
        string[] linhas = {PrepararLinhasCSV(p)};
        // efetivamente lançando todos as linhas no arquivo .CSV
        File.AppendAllLines(PATH,  linhas);
    }
}
}