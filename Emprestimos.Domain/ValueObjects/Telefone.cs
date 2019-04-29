namespace Emprestimos.Domain.ValueObjects
{
    public class Telefone
    {
        public ushort DDD { get; set; }
        public uint Numero { get; set; }

        public Telefone(ushort ddd, uint numero)
        {
            DDD = ddd;
            Numero = numero;
        }

        public override string ToString()
        {
            return $"({DDD}) {Numero}";
        }
    }
}