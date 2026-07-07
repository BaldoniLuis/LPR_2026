using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numeros = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            numeros.Add(random.Next(1, 101));
        }

        numeros.Sort();

        Console.WriteLine("Lista ordenada:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\n");

        numeros.RemoveAll(n => n % 2 == 0);

        Console.WriteLine("Lista sem os números pares:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\n");

        Dictionary<int, int> contagem = new Dictionary<int, int>();

        foreach (int numero in numeros)
        {
            if (contagem.ContainsKey(numero))
                contagem[numero]++;
            else
                contagem[numero] = 1;
        }

        Console.WriteLine("Números repetidos:");

        bool encontrou = false;

        foreach (KeyValuePair<int, int> item in contagem)
        {
            if (item.Value > 1)
            {
                Console.WriteLine(item.Key + " aparece " + item.Value + " vezes.");
                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Não há números repetidos.");
        }
    }
}
