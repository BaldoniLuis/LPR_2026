using System;
using System.Collections.Generic;

class Cliente
{
    public string Nome;
    public List<Reserva> Reservas = new List<Reserva>();

    public void adicionarReserva(Reserva reserva)
    {
        Reservas.Add(reserva);
        reserva.Cliente = this;
    }

    public void listarReservas()
    {
        Console.WriteLine("Reservas do cliente " + Nome + ":");

        foreach (Reserva reserva in Reservas)
        {
            Console.WriteLine("Reserva: " + reserva.Descricao);
        }
    }
}

class Reserva
{
    public string Descricao;
    public Cliente Cliente;
}

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente();

        Console.Write("Digite o nome do cliente: ");
        cliente.Nome = Console.ReadLine();

        Reserva reserva1 = new Reserva();
        Console.Write("Digite a descrição da primeira reserva: ");
        reserva1.Descricao = Console.ReadLine();

        cliente.adicionarReserva(reserva1);

        Reserva reserva2 = new Reserva();
        Console.Write("Digite a descrição da segunda reserva: ");
        reserva2.Descricao = Console.ReadLine();

        cliente.adicionarReserva(reserva2);

        Console.WriteLine();

        cliente.listarReservas();

        Console.ReadKey();
    }
}