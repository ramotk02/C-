using System;

class Program
{
    public static bool Palindrom(string word)
    {

        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("geben Sie ein Wort ein ");
        string input = Console.ReadLine();

        if (Palindrom(input))
        {
            Console.WriteLine("Ja das ist ein palindrome.");
        }
        else
        {
            Console.WriteLine("Nein das ist nicht ein palindrome.");
        }
    }
}
