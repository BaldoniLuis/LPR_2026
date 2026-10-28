using System;

class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public Funcionario(string nome, double salarioBruto)
    {
        Nome = nome;
        SalarioBruto = salarioBruto;

        if (SalarioBruto <= 2000)
            Imposto = 0.10;
        else if (SalarioBruto <= 3000)
            Imposto = 0.15;
        else
            Imposto = 0.20;
    }

    public double SalarioLiquido()
    {
        return SalarioBruto * (1 - Imposto);
    }

    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Salário líquido: R$ " +
            SalarioLiquido().ToString("F2"));
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto += SalarioBruto * porcentagem / 100;
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o salário bruto: R$ ");
        double salario = double.Parse(Console.ReadLine());

        Funcionario funcionario = new Funcionario(nome, salario);

        Console.WriteLine("\n--- Dados do funcionário ---");
        funcionario.MostrarDados();

        Console.Write("\nDigite a porcentagem de aumento: ");
        double aumento = double.Parse(Console.ReadLine());

        funcionario.AumentarSalario(aumento);

        Console.WriteLine("\n--- Dados após o aumento ---");
        funcionario.MostrarDados();
    }
}
