using System;

class Aluno
{
public int Matricula;
public string Nome;
public double Prova1;
public double Prova2;
public double Trabalho;

public double calcMedia()
{
return (Prova1 * 2.5 + Prova2 * 2.5 + Trabalho * 2) / 7;
}

public double calcFinal()
{
double media = calcMedia();

if (media >= 60)
{
return 0; // não vai para a final
}
return 120 - media;
}
}

class Program
{
static void Main(string[] args)
{
Aluno aluno = new Aluno();

Console.Write("Digite a matrícula: ");
aluno.Matricula = int.Parse(Console.ReadLine());

Console.Write("Digite o nome: ");
aluno.Nome = Console.ReadLine();

Console.Write("Digite a nota da prova 1: ");
aluno.Prova1 = double.Parse(Console.ReadLine());

Console.Write("Digite a nota da prova 2: ");
aluno.Prova2 = double.Parse(Console.ReadLine());

Console.Write("Digite a nota do trabalho: ");
aluno.Trabalho = double.Parse(Console.ReadLine());

Console.WriteLine("Média: " + aluno.calcMedia());
Console.WriteLine("Precisa na final: " + aluno.calcFinal());

Console.ReadKey();
}
}