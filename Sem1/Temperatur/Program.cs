internal class Program
{
    public static float F2C(int fahr)
    {
        return (fahr - 32) * 5 / 9f;
    }

    private static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        int fahr = int.Parse(Console.ReadLine());
        float celsius = F2C(fahr);
        Console.WriteLine($"The temperature in Celsius is: {celsius}°C");
    }
}
