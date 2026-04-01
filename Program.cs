using System;
using _01;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente();

        cliente.Nome = "Maria";
        cliente.EstadoUF = "SE";

        ContaBancaria conta = new ContaBancaria();

        conta.Saldo = 6000;
        conta.Titular = cliente;

        AnalisadorCredito analisador = new AnalisadorCredito();

        int scoreFinal =
            analisador.Calcular(conta);

        Console.WriteLine("Nome: " + cliente.Nome);
        Console.WriteLine("Estado: " + cliente.EstadoUF);
        Console.WriteLine("Saldo: R$ " + conta.Saldo);
        Console.WriteLine("Score final: " + scoreFinal);

        Console.ReadLine();
    }
}