using desafio_hospedagem.Models;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Pessoa> hospedes = new List<Pessoa>();
        Suite suitePremium = new Suite("Premium", 15, 100);

        for(int i = 0; i < 10; i++){
            Pessoa hospede = new Pessoa("Fulano", "da Silva");
            hospedes.Add(hospede);
        }

        Reserva reserva = new Reserva();
        reserva.CadastrarSuite(suitePremium);
        reserva.CadastrarHospedes(hospedes);
        Console.WriteLine($"Total de hospedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Total da diária: {reserva.CalcularValorDiaria()}");
    }
}