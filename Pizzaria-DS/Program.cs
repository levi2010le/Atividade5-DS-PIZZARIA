using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BEM-VINDO À PIZZARIA ===\n");

            // Cadastro do usuário
            Usuario usuario = CadastrarUsuario();
            if (usuario == null) return;

            // Menu de pedidos
            Pedido pedido = new Pedido(usuario);
            MenuPizzas(pedido);
            pedido.ExibirTotal();
        }

        static Usuario CadastrarUsuario()
        {
            try
            {
                Console.WriteLine("-- CADASTRO DE USUÁRIO --");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("CPF (com ou sem pontos): ");
                string cpf = Console.ReadLine();

                Usuario usuario = new Usuario(nome, cpf);
                usuario.Cadastrar();
                Console.WriteLine();
                return usuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return null;
            }
        }

        static void MenuPizzas(Pedido pedido)
        {
            List<Pizza> pizzas = CriarListaPizzas();

            while (true)
            {
                Console.WriteLine("\n--- MENU DE PIZZAS ---");
                foreach (var pizza in pizzas)
                {
                    Console.WriteLine($"{pizza.Numero}. {pizza.ObterDescricao()} - R$ {pizza.Preco:F2}");
                }
                Console.WriteLine("0. Finalizar Pedido\n");

                Console.Write("Escolha uma pizza: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "0":
                        return;
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                        Pizza pizzaSelecionada = pizzas.FirstOrDefault(p => p.Numero.ToString() == escolha);
                        if (pizzaSelecionada != null)
                        {
                            pedido.AdicionarPizza(pizzaSelecionada);
                            Console.WriteLine($" {pizzaSelecionada.ObterDescricao()} adicionada ao pedido!");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static List<Pizza> CriarListaPizzas()
        {
            List<Pizza> pizzas = new List<Pizza>
            {
                new Salgada(1, "Calabresa", "Calabresa", "Grande", 45.00m),
                new Salgada(2, "Mussarela", "Mussarela", "Grande", 40.00m),
                new Salgada(3, "Portuguesa", "Portuguesa", "Grande", 50.00m),
                new Salgada(4, "Frango com Catupiry", "Frango com Catupiry", "Grande", 48.00m),
                new Doce(5, "Chocolate", "Chocolate", "Grande", 35.00m),
                new Doce(6, "Banana com Canela", "Banana com Canela", "Grande", 38.00m)
            };

            return pizzas;
        }
    }
}