using System;

public class Program {
    public static void Main(string[] args) {

        Item item = new Item("Pao de queijo", 5.90m);
        Console.WriteLine(item);
    
        Bebida bebida = new Cafe("Capuccino", 4, "Grande", "Expresso");
        Console.WriteLine(bebida);

        Sobremesa sobremesa = new Sobremesa("Torta", 5.00m, "Limão");
        Console.WriteLine(sobremesa);
   }
}
