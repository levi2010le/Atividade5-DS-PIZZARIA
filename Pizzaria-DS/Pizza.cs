using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_DS
{
    internal class Pizza
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Sabor { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }

        public Pizza(int numero, string nome, string sabor, string tamanho, decimal preco)
        {
            Numero = numero;
            Nome = nome;
            Sabor = sabor;
            Tamanho = tamanho;
            Preco = preco;
        }

        public virtual string ObterDescricao()
        {
            return $"{Nome} - {Sabor}";
        }

        public virtual string ObterTipo()
        {
            return "Pizza";
        }
    }
}