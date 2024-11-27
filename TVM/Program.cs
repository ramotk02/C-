using System;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Wert: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Wert: ");
            int value2 = Convert.ToInt32(Console.ReadLine()); 

            (value1, value2) = (value2, value1);

            Console.WriteLine("Nach der Magie!");
            Console.WriteLine("1. Wert: " + value1);
            Console.WriteLine("2. Wert: " + value2);
        }
    }
}
