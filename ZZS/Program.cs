using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Wert ");
        int zahl1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. Wert ");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        if (zahl1 <= zahl2)
        {
            Console.WriteLine($"{zahl1}, {zahl2}");
        }
        else
        {
            Console.WriteLine($"{zahl2}, {zahl1}");
        }
    }
}
