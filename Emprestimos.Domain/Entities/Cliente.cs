using Emprestimos.Domain.ValueObjects;
using System;

namespace Emprestimos.Domain.Entities
{
    public class Cliente
    {
        public const int NAME_MIN_LENGTH = 10;
        public const int NAME_MAX_LENGTH = 100;
        public const decimal RENDA_MIN_VALUE = 0;
        public const decimal RENDA_MAX_VALUE = decimal.MaxValue;

        public int ClienteId { get; private set; }
        public CPF Cpf { get; private set; }
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public Endereco Endereco { get; private set; }
        public Telefone Telefone { get; private set; }
        public Email Email { get; private set; }
        public decimal Renda { get; private set; }

        public Cliente(CPF cpf, string nome, DateTime nascimento, Endereco endereco, Telefone telefone, decimal renda, Email email = null)
        {
            SetCpf(cpf);
            SetNome(nome);
            SetNascimento(nascimento);
            SetEndereco(endereco);
            SetTelefone(telefone);
            SetRenda(renda);
            SetEmail(email);
        }

        public Cliente SetRenda(decimal renda)
        {
            Renda = renda;
            return this;
        }

        public Cliente SetId(int id)
        {
            ClienteId = id;
            return this;
        }

        public Cliente SetCpf(CPF cpf)
        {
            Cpf = cpf;
            return this;
        }

        public Cliente SetNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public Cliente SetNascimento(DateTime nascimento)
        {
            Nascimento = nascimento;
            return this;
        }

        public Cliente SetEndereco(Endereco endereco)
        {
            Endereco = endereco;
            return this;
        }

        public Cliente SetTelefone(Telefone telefone)
        {
            Telefone = telefone;
            return this;
        }

        public Cliente SetEmail(Email email)
        {
            Email = email;
            return this;
        }
    }
}
