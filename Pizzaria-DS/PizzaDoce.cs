using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_DS
{
    internal class Doce : Pizza
    {
        public Doce(int numero, string nome, string sabor, string tamanho, decimal preco)
            : base(numero, nome, sabor, tamanho, preco)
        {
        }

        public override string ObterDescricao()
        {
            return $"{Nome} (Doce) - {Sabor} - {Tamanho}";
        }

        public override string ObterTipo()
        {
            return "Doce";
        }
    }
}