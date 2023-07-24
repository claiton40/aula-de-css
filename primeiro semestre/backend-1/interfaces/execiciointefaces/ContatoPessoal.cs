namespace execiciointefaces
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf;

        bool IContatoPessoal.ValidarCpf(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}
