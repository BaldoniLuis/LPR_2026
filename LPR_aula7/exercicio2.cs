class Exercicio2
{
    public static void Executar()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite o número que deseja pesquisar: ");
        int pesquisa = int.Parse(Console.ReadLine());

        int ocorrencias = 0;

        Console.WriteLine("\nPosições encontradas:");

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == pesquisa)
            {
                Console.WriteLine($"Posição {i}");
                ocorrencias++;
            }
        }

        if (ocorrencias > 0)
        {
            Console.WriteLine($"\nO número {pesquisa} apareceu {ocorrencias} vez(es).");
        }
        else
        {
            Console.WriteLine($"\nO número {pesquisa} não foi encontrado no vetor.");
        }
    }
}