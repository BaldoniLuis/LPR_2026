using System;

class Produto
{
    public string Nome;
    public double Preco;
}

class Pedido
{
    public Produto produto;
    public int quantidade;

    public double calcTotal()
    {
        return produto.Preco * quantidade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.Write("Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        produto.Preco = double.Parse(Console.ReadLine());

        Pedido pedido = new Pedido();

        pedido.produto = produto;

        Console.Write("Digite a quantidade: ");
        pedido.quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Nome do produto: " + pedido.produto.Nome);
        Console.WriteLine("Quantidade: " + pedido.quantidade);
        Console.WriteLine("Preço total: R$ " + pedido.calcTotal().ToString("F2"));

        Console.ReadKey();
    }
}