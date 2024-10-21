using System; //É o equivalente ao import (JAVA)
              //namespace é equivallent ao package (JAVA)
public class Item (string nome, decimal preco){
    // Atributos da classe
    public string Nome { get; private set; } = nome;
    public decimal Preco {get; protected set; } = preco;


    // Métodos
    public virtual decimal CalcularPreco() {
        return Preco;
    }

    // ToString
    public override string ToString() {
        return $"Item: {Nome}, Preco: {Preco}";
    }
}  
