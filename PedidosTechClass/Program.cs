using System;

namespace PedidosTechClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('-', 50);
            int opcoes;
            double preco;

            Console.WriteLine("Escolha o Produto que deseja comprar");

            Console.WriteLine("\nTabela de produtos: ");
            Console.WriteLine(sep);

            Console.WriteLine("1. Camisetas Personalizadas - R$ 25,00 por unidade");
            Console.WriteLine("2. Canecas de Porcelana - R$ 15,00 por unidade");
            Console.WriteLine("3. Kits de Maquiagem - R$ 50,00 por kit");
            Console.WriteLine("4. Fones de Ouvido Bluetooth - R$ 80,00 por unidade");
            Console.WriteLine("5. Livros Best-sellers - R$ 30,00 por unidade");
            Console.WriteLine(sep);

            Console.Write("\nSelecione a opção de produto que deseja: ");
            opcoes = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcoes)
            {
                case 1:
                    preco = 25;
                    ProcessarPedido("Camisetas Personalizadas", preco);
                    break;

                case 2:
                    preco = 15;
                    ProcessarPedido("Canecas de Porcelana", preco);
                    break;

                case 3:
                    preco = 50;
                    ProcessarPedido("Kits de Maquiagem", preco);
                    break;

                case 4:
                    preco = 80;
                    ProcessarPedido("Fones de Ouvido Bluetooth", preco);
                    break;

                case 5:
                    preco = 30;
                    ProcessarPedido("Livros Best-sellers", preco);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void ProcessarPedido(string produto, double preco)
        {
            Console.WriteLine($"Você selecionou {produto}. Preço unitário: R$ {preco:0.00}");
            Console.Write("Digite a quantidade desejada: ");
            double quantidade = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de desconto (se houver): ");
            double desconto = double.Parse(Console.ReadLine());

            Pedidos pedido = new Pedidos(quantidade, desconto, preco);
            double valorComDesconto = pedido.CalcularPrecoComDesconto();

            Console.WriteLine($"\nValor total com desconto: R$ {valorComDesconto:0.00}");
        }
    }
}