public class Pedidos
{
    public double Quantidade { get; set; }
    public double Desconto { get; set; }
    public double Preco { get; set; }

    public Pedidos(double quantidade, double desconto, double preco)
    {
        Quantidade = quantidade;
        Desconto = desconto;
        Preco = preco;
    }

    public double CalcularValorDesconto()
    {
        return (Quantidade * Preco) * (Desconto / 100);
    }

    public double CalcularPrecoComDesconto()
    {
        double valordesconto = CalcularValorDesconto();
        return (Quantidade * Preco) - valordesconto;
    }
}
