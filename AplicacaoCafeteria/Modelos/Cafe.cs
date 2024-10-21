using System;

public class Cafe : Bebida {
    
    //Atributos
    public string Tipo { get; private set; }

    // Construtor
    public Cafe (string nome, decimal preco, string tamanho, string tipo): base (nome, preco, tamanho) {
        Tipo = tipo;
        Preco = CalcularPreco();
    }

    //Metodos
    public override decimal CalcularPreco() {
        Preco = Tamanho == "Grande" ? Preco*2 : Preco;
        return Preco;
    }

    // ToString

    public override string ToString(){
        return $"Item: {Nome}, Preco: {CalcularPreco()}, Tamanho: {Tamanho}, Tipo: {Tipo}";
    }
}