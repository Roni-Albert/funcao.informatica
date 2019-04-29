namespace Emprestimos.Domain.ValueObjects
{
    public class CPF
    {
        public ulong Numero { get; private set; }

        public CPF(ulong numero)
        {
            Numero = numero;
        }

        public override string ToString()
        {
            return Numero.ToString();
        }
    }
}