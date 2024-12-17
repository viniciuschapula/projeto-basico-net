using desafio_hospedagem.Models;

namespace desafio_hospedagem.Models;
public class Reserva {
    public List<Pessoa> Hospedes {get;set;}
    public Suite Suite {get;set;}
    public int DiasReservados {get;set;}

    public void CadastrarHospedes(List<Pessoa> hospedes){
        this.Hospedes = hospedes;
        if(hospedes.Count < Suite.Capacidade){
            Console.WriteLine("Hospedes cadastrados na suite;");
        }
        else{
            Console.WriteLine("Capacidade maxima de hospodes maior que o permitido!");
        }
    }

    public void CadastrarSuite(Suite suite){
        this.Suite = suite;
        Console.WriteLine("Suite cadastrada");
    }

    public int ObterQuantidadeHospedes(){
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria(){
        decimal totalValorDiaria = 0;

        totalValorDiaria = Suite.ValorDiaria * Hospedes.Count;

        if(Hospedes.Count >= 10)
            totalValorDiaria = totalValorDiaria - (totalValorDiaria * 0.1m);

        return totalValorDiaria;
    }
}