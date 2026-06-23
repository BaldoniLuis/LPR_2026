using System;

partial class Program
{
    struct Produto
    {
        public string nome;
        public int codigo;
        public double preco;
        public int quantidade;
    }

    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[3];
        double valorTotal = 0;

        Console.WriteLine("Digite os dados de 3 produtos:\n");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Produto " + (i + 1) + ":");

            Console.Write("Nome: ");
            produtos[i].nome = Console.ReadLine();

            Console.Write("Código: ");
            produtos[i].codigo = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            produtos[i].preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        Console.WriteLine("\n===== PRODUTOS CADASTRADOS ====");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Produto " + (i + 1) + ":");
            Console.WriteLine("Nome: " + produtos[i].nome);
            Console.WriteLine("Código: " + produtos[i].codigo);
            Console.WriteLine("Preço: R$ " + produtos[i].preco);
            Console.WriteLine("Quantidade: " + produtos[i].quantidade);

            valorTotal += produtos[i].preco * produtos[i].quantidade;

            Console.WriteLine();
        }

        Console.WriteLine("Valor total em estoque: R$ " + valorTotal);
    }
}