using Emprestimos.Domain.Entities;
using Emprestimos.Domain.ValueObjects;
using System.Collections.Generic;

namespace Emprestimos.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> List();
        Cliente Get(CPF cpf);
        Cliente Get(int id);
        void Update(Cliente cliente);
        void Add(Cliente cliente);
        void Delete(Cliente cliente);
        void Delete(int id);
        void AddOrUpdate(Cliente cliente);
        void Commit();
    }
}
