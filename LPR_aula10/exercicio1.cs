
using System;

class Retangulo
{
    public double Altura;
    public double Largura;

    public double calcArea()
    {
        return Altura * Largura;
    }
    public double calcPerimetro()
    {
        return 2 * (Altura + Largura);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        Console.Write("Digite a altura do retângulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine());

        Console.Write("Digite a largura do retângulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine());

        Console.WriteLine("Área: " + retangulo.calcArea());
        Console.WriteLine("Perímetro: " + retangulo.calcPerimetro());

        Console.ReadKey();
    }
}
