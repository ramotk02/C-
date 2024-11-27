using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zeit {s}");
        int totalSeconds = Convert.ToInt32(Console.ReadLine());

        int hours = totalSeconds / 3600;
        int remainingSeconds = totalSeconds % 3600; 

        int minutes = remainingSeconds / 60;
        remainingSeconds = remainingSeconds % 60; 

        Console.WriteLine($"{totalSeconds} secondes = {hours} heure(s), {minutes} minute(s) et {remainingSeconds} seconde(s).");
    }
}
