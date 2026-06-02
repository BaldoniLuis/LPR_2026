class Exercicio1
{
    public static void Executar()
    {



        int[] numeros = new int[10];

        List<int> paresLista = new List<int>();
        List<int> imparesLista = new List<int>();

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());


            if (numeros[i] % 2 == 0)
            {
                paresLista.Add(numeros[i]);
            }
            else
            {
                imparesLista.Add(numeros[i]);
            }
        }

        int[] vetorPares = paresLista.ToArray();
        int[] vetorImpares = imparesLista.ToArray();

        Console.WriteLine("\n Resultado:");

        Console.Write("PAR: ");
        Console.WriteLine(string.Join(" ", vetorPares));

        Console.Write("ÍMPAR: ");
        Console.WriteLine(string.Join(" ", vetorImpares));
    }
} 