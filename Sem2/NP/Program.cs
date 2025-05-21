using System.Globalization;
internal class Program
{

    static int RekSumme(int n)
    {
        if (n == 1)
        {
             Console.WriteLine($"ich habe keine wahl und muss die Summe von 1 lieferen ");
            return 1;
        }
        else
        {
            Console.WriteLine($"Du rechnest die {n} und ich mache die Summe von {n-1} ");
            return (n + RekSumme(n - 1));
        }
    }

    static int Summe(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum = sum + i;
        }
        return sum;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine($"Die Summe lautet {Summe(10)}");
    }
}