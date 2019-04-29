using Emprestimos.Domain.Enums;

namespace Emprestimos.Domain.ValueObjects
{
    public class Endereco
    {
        public string Logradouro { get; private set; }
        public int? Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public UF UF { get; private set; }

        public Endereco(UF uf, string cidade, string bairro, string logradouro, int? numero = null, string complemento = null)
        {
            UF = uf;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
        }
    }
}