namespace desafio_hospedagem.Models;

public class Pessoa {

public Pessoa (string nome, string sobrenome){
    this.Nome = nome;
    this.Sobrenome = sobrenome;
}

    public string Nome {get; set;} = string.Empty;
    public string Sobrenome {get;set;} = string.Empty;
}