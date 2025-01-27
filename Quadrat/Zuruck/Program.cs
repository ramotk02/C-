internal class Program
{
    public static int quad(int x)
    {
        int result = x*x;
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Geben Sie eine Zahl ein:");

        int meinezahl= Convert.ToInt32(Console.ReadLine());
        int quadrat = quad(meinezahl);
        Console.WriteLine($"Das Quadrat von {meinezahl} ist: {quadrat}");
    }
}