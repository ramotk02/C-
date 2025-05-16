using System;

internal class Program
{
    public static int Hoch(int x, int y)
    {
        return (int)Math.Pow(x, y);
        
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.Write("Geben Sie eine Zahl ein: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Geben Sie den Exponenten ein: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = Hoch(a, b);
        Console.WriteLine($"{a} hoch {b} ist {result}");
    }
}