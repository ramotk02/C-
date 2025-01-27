using System;

class MainClass {
    
    public static int nachRabatt(int x, int y)
    {
        int result = x - (x * y / 100);
        return result;
    }

    public static void Main (string[] args) {
        Console.WriteLine("Geben Sie ein Preis:");
        int price = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Wie viel Rabatt haben Sie?");
        int rabatt = Convert.ToInt32(Console.ReadLine());
        
        int nachRabattV = nachRabatt(price, rabatt);
        Console.WriteLine("Nach Rabatt: " + nachRabattV);
    }
}