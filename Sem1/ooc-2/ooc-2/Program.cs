Console.WriteLine("hello world");

while (true)
{
    {

    }
    Console.WriteLine("What's ur name ?");
    String a = Console.ReadLine();

    Console.WriteLine("How old are you?");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Hello " + a);

    if (b <= 18)
    {
        Console.WriteLine("You're mineur");
    }
    else
    {
        Console.WriteLine("You're old");
    }
}

