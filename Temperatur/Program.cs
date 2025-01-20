using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        if (args.Length > 0)
        {
            Console.WriteLine("Argument 0: " + args[0]);
        }
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Argument {i}: {args[i]}");
        }

        Console.WriteLine("Geben Sie den Namen ein:");
        string input = Console.ReadLine();  
       
}
