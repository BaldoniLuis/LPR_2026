using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Quantidade de nomes: ");
        int x = int.Parse(Console.ReadLine());

        List<string> nomes = new List<string>();

        for (int i = 0; i < x; i++)
        {
            nomes.Add(Console.ReadLine());
        }

        List<int> tamanhos = new List<int>();

        foreach (string nome in nomes)
        {
            if (!tamanhos.Contains(nome.Length))
                tamanhos.Add(nome.Length);
        }

        tamanhos.Sort();

        bool aindaTem = true;

        while (aindaTem)
        {
            aindaTem = false;
            List<string> linha = new List<string>();

            foreach (int tam in tamanhos)
            {
                for (int i = 0; i < nomes.Count; i++)
                {
                    if (nomes[i] != null && nomes[i].Length == tam)
                    {
                        linha.Add(nomes[i]);
                        nomes[i] = null; 
                        aindaTem = true;
                        break;
                    }
                }
            }

            if (linha.Count > 0)
                Console.WriteLine(string.Join(" ", linha));
        }
    }
}