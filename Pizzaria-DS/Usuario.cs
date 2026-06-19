using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_DS
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Usuario(string nome, string cpf)
        {
            if (!ValidarCpf(cpf))
                throw new ArgumentException("CPF inválido");

            this.Nome = nome;
            this.CPF = cpf;
        }

        public static bool ValidarCpf(string cpf)
        {
            var numeros = new string(cpf.Where(char.IsDigit).ToArray());
            if (numeros.Length != 11 || new string(numeros[0], 11) == numeros) return false;

            for (int j = 9; j < 11; j++)
            {
                int soma = 0;
                for (int i = 0; i < j; i++) soma += (numeros[i] - '0') * ((j + 1) - i);
                int resto = (soma * 10) % 11;
                if (resto == 10) resto = 0;
                if (numeros[j] - '0' != resto) return false;
            }
            return true;
        }

        public bool Cadastrar()
        {
            try
            {
                Console.WriteLine($" Usuário cadastrado com sucesso!");
                Console.WriteLine($"  Nome: {Nome}");
                Console.WriteLine($"  CPF: {CPF}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Erro ao cadastrar: {ex.Message}");
                return false;
            }
        }
    }
}