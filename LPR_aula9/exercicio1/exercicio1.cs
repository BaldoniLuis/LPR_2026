using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> notas = new List<double>();

        Console.WriteLine("--- Cadastro de Notas ---");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite a {i}ª nota: ");
            
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, digite um número.");
                i--;
            }
        }

        Console.WriteLine("\n--- Resultados ---");

        Console.Write("Todas as notas cadastradas: ");
        Console.WriteLine(string.Join(" | ", notas));

        double maiorNota = notas.Max();
        Console.WriteLine($"A maior nota: {maiorNota}");

        double menorNota = notas.Min();
        Console.WriteLine($"A menor nota: {menorNota}");

        double media = notas.Average();
        Console.WriteLine($"A média das notas: {media:F2}");
    }
}