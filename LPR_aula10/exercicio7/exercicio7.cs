using System;
using System.Collections.Generic;

class Livro
{
    public string Titulo;
    public string Autor;
    public int AnoPublicacao;

    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
}
class Biblioteca
{
    public List<Livro> Livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }

    public void ListarLivros()
    {
        Console.WriteLine("\nLivros cadastrados na biblioteca:");

        foreach (Livro livro in Livros)
        {
            Console.WriteLine("Título: " + livro.Titulo);
            Console.WriteLine("Autor: " + livro.Autor);
            Console.WriteLine("Ano de publicação: " + livro.AnoPublicacao);
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        Console.Write("Digite o autor do livro: ");
        string autor = Console.ReadLine();

        Console.Write("Digite o ano de publicação: ");
        int ano = int.Parse(Console.ReadLine());

        Livro livro1 = new Livro(titulo, autor, ano);

        biblioteca.AdicionarLivro(livro1);

        Console.WriteLine("\nLivro cadastrado com sucesso!");

        biblioteca.ListarLivros();

        Console.ReadKey();
    }
}