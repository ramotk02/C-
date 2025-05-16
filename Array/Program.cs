using System;

public class Program
{
    public static void Main(string[] args)
    {

        String[] Bigarray = { "B123", "C234", "A345", "C15", "B117", "G3003", "C235", "B179" };

        foreach (string array in Bigarray)
        {
            if (array.StartsWith("B"))
            {
             Console.WriteLine(array);
            }
        }
    }

}
