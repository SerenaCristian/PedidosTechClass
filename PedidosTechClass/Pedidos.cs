public class Pedidos
{
    private double _quantidade;
    private double _desconto;
    public double _preco;



    public double Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }
    public double Desconto
    {
        get { return _desconto; }
        set { _desconto = value; }
    }

    public double Preco
    {
        get { return _desconto; }
        set { _desconto = value; }
    }



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
