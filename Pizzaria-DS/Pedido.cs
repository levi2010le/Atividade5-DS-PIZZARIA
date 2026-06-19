using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_DS
{
    internal class Pedido
    {
        public Usuario Usuario { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public Total Total { get; set; }

        public Pedido(Usuario usuario)
        {
            Usuario = usuario;
            Pizzas = new List<Pizza>();
            Total = new Total(Pizzas);
        }

        public void AdicionarPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
            Total.CalcularTotal();
        }

        public decimal CalcularTotal()
        {
            return Pizzas.Sum(p => p.Preco);
        }

        public void ExibirTotal()
        {
            Console.WriteLine("\n=== RESUMO DO PEDIDO ===");
            Console.WriteLine($"Cliente: {Usuario.Nome}");
            Console.WriteLine($"CPF: {Usuario.CPF}");

            Total.ExibirDetalhes();
        }
    }
}