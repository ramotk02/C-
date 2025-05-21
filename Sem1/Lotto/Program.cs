using System;
using System.Linq;

class Program
{
    private static void Main(string[] args)
    {
        int[] LottoSchein = new int[50];
        for (int i = 0; i < LottoSchein.Length; i++)
        {
            LottoSchein[i] = i + 1;
        }

        for (int i = 0; i < LottoSchein.Length; i++)
        {
            Console.WriteLine($"Der Platz {i + 1} hat den Wert {LottoSchein[i]}");
        }

        int[] Eingabe = new int[6];
        for (int a = 0; a < 6; a++)
        {
            Console.WriteLine($"Gib deine Wahl Nummer {a + 1} ein:");
            int Zahl = Convert.ToInt32(Console.ReadLine());

            while (Eingabe.Contains(Zahl))
            {
                Console.WriteLine($"Die Zahl {Zahl} hast du schon eingegeben. Gib bitte eine andere Zahl ein.");
                Zahl = Convert.ToInt32(Console.ReadLine());
            }
            Eingabe[a] = Zahl;
        }

        Console.Write("Deine eingegebenen Zahlen sind: ");
        for (int a = 0; a < 6; a++)
        {
            Console.Write($"|{Eingabe[a]}");
        }
        Console.WriteLine("|\n");

        Random random = new Random();
        int[] Zufallszahlen = new int[6];
        for (int z = 0; z < Zufallszahlen.Length; z++)
        {
            Zufallszahlen[z] = random.Next(1, 51); 
        }

        Console.Write("Die zufällig gezogenen Zahlen sind: ");
        for (int z = 0; z < 6; z++)
        {
            Console.Write($"|{Zufallszahlen[z]}");
        }
        Console.WriteLine("|\n");

        int matches = Eingabe.Intersect(Zufallszahlen).Count();
        Console.WriteLine($"Sie haben {matches} Zahl(en) richtig.");
    }
}
 