using System;

partial class Program
{
    struct Filme
    {
        public string titulo;
        public string diretor;
        public int ano;
        public int minutos;
    }

    static void Main(string[] args)
    {
        Filme[] filmes = new Filme[3];

        Console.WriteLine("Digite o título, diretor, ano de lançamento e duração de 3 filmes");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Filme " + (i + 1) + ":");
            Console.Write("Título: ");
            filmes[i].titulo = Console.ReadLine();
            Console.Write("Diretor: ");
            filmes[i].diretor = Console.ReadLine();
            Console.Write("Ano de lançamento: ");
            filmes[i].ano = int.Parse(Console.ReadLine());
            Console.Write("Duração (em minutos): ");
            filmes[i].minutos = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Console.WriteLine("\n=====FILMES CADASTRADOS=====");

        for (int i = 0; i <3; i++)
        {
            Console.WriteLine("Filme " + (i + 1) + ":");
            Console.WriteLine("Título: " + filmes[i].titulo);
            Console.WriteLine("Diretor: " + filmes[i].diretor);
            Console.WriteLine("Ano de lançamento: " + filmes[i].ano);
            Console.WriteLine("Duração: " + filmes[i].minutos + " minutos");
            Console.WriteLine();
        }
        Filme maisAntigo = filmes[0];
        for (int i = 1; i < 3; i++)
        {
            if (filmes[i].ano < maisAntigo.ano)
            {
                maisAntigo = filmes[i];
            }
        }
        Console.WriteLine("O filme mais antigo é: " + maisAntigo.titulo + " (" + maisAntigo.ano + ")");

    }
}
