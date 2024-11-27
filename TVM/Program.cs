using System;
namespace Magic
{
    class Program
    {
        static void Main(string[] ags)
        {
            Console.Write("1.  Wert: ");
            string inputline = Console.ReadLine();
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Wert: ");
            inputline = Console.ReadLine();
            int value2 = Convert.ToInt32(inputline);





            Console.WriteLine("Nach der Magie!");
            Console.WriteLine("1. wert: "+ value1);
            Console.WriteLine("2. Wert: "+ value2);

        }
    }
}