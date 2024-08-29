using System;



namespace PedidosTechClass
{
    public class Pedidos
    {
        string traco = new string('-', 50);
        int opcoes;
        double quantidade;
        double desconto;
        double preco;
        double valordesconto;
        double valorCaneca;


        public void PedidosMenu()
        {
            Console.WriteLine("Escolha o Produto que deseja comprar ");


            Console.WriteLine("\nTabela de produtos: ");
            Console.WriteLine(traco);

            Console.WriteLine("1.Camisetas Personalizadas - R$ 25,00 por unidade");
            Console.WriteLine("2.Canecas de Porcelana - R$ 15,00 por unidade");
            Console.WriteLine("3.Kits de Maquiagem - R$ 50,00 por kit");
            Console.WriteLine("4.Fones de Ouvido Bluetooth - R$ 80,00 por unidade");
            Console.WriteLine("5.Livros Best-sellers - R$ 30,00 por unidade");
            Console.WriteLine(traco);

            Console.Write("\nSeleicione a opção de produto que deseja: ");
            opcoes = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcoes)
            {
                case 1:
                    Console.WriteLine("Camisetas Personalizadas");
                    Console.WriteLine(traco);

                    Console.Write("Digite a quantidade desejada: ");
                    quantidade = int.Parse(Console.ReadLine());

                    preco = 25;

                    double valorTotal = quantidade * preco;

                    if (quantidade == 10)
                    {
                        Console.WriteLine("\nCobrar valor total, desconto não aplicável");
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine($"Preço a pagar pelas Camisetas Personalizadas é de: {valorTotal:C}");
                    }
                    else if (quantidade >= 11 && quantidade <= 20)
                    {
                        desconto = 0.10;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 10% de Desconto");
                        Console.WriteLine($"Preço a pagar pelas Camisetas Personalizadas é de: {valorTotal:C}");
                    }

                    else if (quantidade >= 21 && quantidade <= 50)
                    {
                        desconto = 0.20;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 20% de Desconto");
                        Console.WriteLine($"Preço a pagar pelas Camisetas Personalizadas é de: {valorTotal:C}");
                    }

                    else
                    {
                        desconto = 0.25;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 25% de Desconto");
                        Console.WriteLine($"Preço a pagar pelas Camisetas Personalizadas é de: {valorTotal:C}");
                    }
                    break;

                case 2:
                    Console.WriteLine("Canecas de porcelana");
                    Console.WriteLine(traco);

                    Console.Write("Digite a quantidade desejada: ");
                    quantidade = int.Parse(Console.ReadLine());

                    preco = 15;

                    valorTotal = quantidade * preco;

                    if (quantidade == 10)
                    {
                        Console.WriteLine("Cobrar valor total, desconto não aplicável");
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine($"\nPreço a pagar pela caneca é de: {valorTotal:C}"); ;
                    }
                    else if (quantidade >= 11 && quantidade <= 20)
                    {
                        desconto = 0.10;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 10% de Desconto");
                        Console.WriteLine($"Preço a pagar pela caneca é de: {valorTotal:C}");
                    }

                    else if (quantidade >= 21 && quantidade <= 50)
                    {
                        desconto = 0.20;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 20% de Desconto");
                        Console.WriteLine($"Preço a pagar pela caneca é de: {valorTotal:C}");
                    }

                    else
                    {
                        desconto = 0.25;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 25% de Desconto");
                        Console.WriteLine($"Preço a pagar pela caneca é de: {valorTotal:C}");
                    }
                    break;

                case 3:
                    Console.WriteLine("Kits de Maquiagem");
                    Console.WriteLine(traco);

                    Console.Write("Digite a quantidade desejada: ");
                    quantidade = int.Parse(Console.ReadLine());

                    preco = 50;

                    valorTotal = quantidade * preco;

                    if (quantidade == 10)
                    {
                        Console.WriteLine("Cobrar valor total, desconto não aplicável");
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine($"Preço a pagar pelo  Kits de Maquiagem é de: {valorTotal:C}");
                    }
                    else if (quantidade >= 11 && quantidade <= 20)
                    {
                        desconto = 0.10;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 10% de Desconto");
                        Console.WriteLine($"Preço a pagar pelo  Kits de Maquiagem é de: {valorTotal:C}");
                    }

                    else if (quantidade >= 21 && quantidade <= 50)
                    {
                        desconto = 0.20;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 20% de Desconto");
                        Console.WriteLine($"Preço a pagar pelo  Kits de Maquiagem é de: {valorTotal:C}");
                    }

                    else
                    {
                        desconto = 0.25;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 25% de Desconto");
                        Console.WriteLine($"Preço a pagar pelo  Kits de Maquiagem é de: {valorTotal:C}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Fones de Ouvido Bluetooth ");
                    Console.WriteLine(traco);

                    Console.Write("Digite a quantidade desejada: ");
                    quantidade = int.Parse(Console.ReadLine());

                    preco = 80;

                    valorTotal = quantidade * preco;

                    if (quantidade == 10)
                    {
                        Console.WriteLine("Cobrar valor total, desconto não aplicável");
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine($"Preço a pagar pelos Fones de Ouvido Bluetooth é de: {valorTotal:C}");
                    }
                    else if (quantidade >= 11 && quantidade <= 20)
                    {
                        desconto = 0.10;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 10% de Desconto");
                        Console.WriteLine($"Preço a pagar pelos Fones de Ouvido Bluetooth é de: {valorTotal:C}");
                    }

                    else if (quantidade >= 21 && quantidade <= 50)
                    {
                        desconto = 0.20;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 20% de Desconto");
                        Console.WriteLine($"Preço a pagar pelos Fones de Ouvido Bluetooth é de: {valorTotal:C}");
                    }

                    else
                    {
                        desconto = 0.25;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 25% de Desconto");
                        Console.WriteLine($"Preço a pagar pelos Fones de Ouvido Bluetooth é de: {valorTotal:C}");
                    }
                    break;

                case 5:
                    Console.WriteLine("Livros Best-sellers");
                    Console.WriteLine(traco);

                    Console.Write("Digite a quantidade desejada: ");
                    quantidade = int.Parse(Console.ReadLine());

                    preco = 30;

                    valorTotal = quantidade * preco;

                    if (quantidade == 10)
                    {
                        Console.WriteLine("Cobrar valor total, desconto não aplicável");
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine($"Preço a pagar pelo Livro Best-sellers é de: {valorTotal:C}");
                    }
                    else if (quantidade >= 11 && quantidade <= 20)
                    {
                        desconto = 0.10;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 10% de Desconto");
                        Console.WriteLine($"Preço a pagar pelo Livro Best-sellers é de: {valorTotal:C}");
                    }

                    else if (quantidade >= 21 && quantidade <= 50)
                    {
                        desconto = 0.20;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 20% de Desconto");
                        Console.WriteLine($"Preço a pagar pelo Livro Best-sellers é de: {valorTotal:C}");
                    }

                    else
                    {
                        desconto = 0.25;
                        double valorDesconto = valorTotal * desconto;
                        valorTotal -= valorDesconto;
                        Console.WriteLine($"\nValor unitário é de: {preco:C}");
                        Console.WriteLine("\nParabéns, você ganhou 25% de Desconto");
                        Console.WriteLine($"Preço a pagar pelo Livro Best-sellers é de: {valorTotal:C}");
                    }
                    break;


            }

        }
    }
}
