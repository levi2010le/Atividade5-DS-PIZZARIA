using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_DS
{
    internal class Total
    {
        public List<Pizza> Pizzas { get; set; }
        public decimal ValorTotal { get; set; }

        public Total(List<Pizza> pizzas)
        {
            Pizzas = pizzas;
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            ValorTotal = Pizzas.Sum(p => p.Preco);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("\n=== DETALHES DO TOTAL ===");
            Console.WriteLine($"Quantidade de Pizzas: {Pizzas.Count}");
            Console.WriteLine("\nPizzas no Pedido:");

            foreach (var pizza in Pizzas)
            {
                Console.WriteLine($"  - {pizza.ObterDescricao()} - R$ {pizza.Preco:F2} [{pizza.ObterTipo()}]");
            }

            Console.WriteLine($"\nValor Total: R$ {ValorTotal:F2}");
        }
    }
}