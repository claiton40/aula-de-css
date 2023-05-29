namespace exercicio_de_fixação_usando_mvc_em_console.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preço { get; set; }

        private const string CAMINHO = "Banco/Produto.csv";

        public Produto()
        {
            string pasta = CAMINHO.Split("/")[0];
            {
                if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }
            }
            if (!File.Exists(CAMINHO))
            {
                File.Create(CAMINHO);
            }
        }
        public List<Produto> ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";")
                Produto p = new Produto();
                
            }

            return produtos;
        }
    }
}