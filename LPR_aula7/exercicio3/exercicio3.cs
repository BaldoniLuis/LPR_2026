        int[] vetor = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite o número que deseja pesquisar: ");
        int numero = int.Parse(Console.ReadLine());

        int ocorrencias = 0;

        Console.WriteLine("\nPosições encontradas:");

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numero)
            {
                Console.WriteLine($"Posição {i}");
                ocorrencias++;
            }
        }

        if (ocorrencias > 0)
        {
            Console.WriteLine($"\nO número {numero} apareceu {ocorrencias} vez(es).");
        }
        else
        {
            Console.WriteLine($"\nO número {numero} não foi encontrado no vetor.");
        }