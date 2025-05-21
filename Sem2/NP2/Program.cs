using System;

internal class Program
{
    int[] MeinArray = new int[10];

    public Program()
    {
        for (int i = 0; i < MeinArray.Length; i++)
        {
            MeinArray[i] = i * 10;
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World !!!");
        Program p = new Program();
    }
}
