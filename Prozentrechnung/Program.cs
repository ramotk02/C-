Console.WriteLine("Prozentrechnung");

Console.WriteLine("Grundbetrag?");
int Grundbetrag1 = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Prozentsatz?");
int Prozentsatz = Convert.ToInt32(Console.ReadLine());  

int percentage = (Grundbetrag1 * Prozentsatz) / 100;  

Console.WriteLine(Prozentsatz +" % von " + Grundbetrag1 + " Euro ist "+ percentage + " Euro.");
