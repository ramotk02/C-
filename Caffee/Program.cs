internal class Program
{
    public static float F2C(int fahr)
    {
        return (fahr - 32) * 5 / 9f;
    }

    private static void Main(string[] args)
    {
        Console.Write("Geben Sie ihnen Temperatur of Fahrenheit: ");
        int fahr = int.Parse(Console.ReadLine());
        float celsius = F2C(fahr);
        Console.WriteLine($"Die Temperature in Celsius: {celsius}°C");
    }
}
