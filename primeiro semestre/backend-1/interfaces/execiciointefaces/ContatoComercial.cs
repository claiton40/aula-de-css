
namespace execiciointefaces
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj;

        bool IContatoComercial.ValidarCnpj(string _Cnpj)
        {
            throw new NotImplementedException();
        }
    }
}