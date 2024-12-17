namespace desafio_hospedagem.Models;
public class Suite {

    public Suite (string tipoSuite, int capacidade, decimal valorDiaria){
        this.TipoSuite = tipoSuite;
        this.Capacidade = capacidade;
        this.ValorDiaria = valorDiaria;
    }

    public string TipoSuite {get; set;} = string.Empty;
    public int Capacidade {get;set;} 
    public decimal ValorDiaria {get;set;}
}