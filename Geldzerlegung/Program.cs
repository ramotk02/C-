Console.WriteLine("Zerlegung von Cent-Beträgen. ");
Console.WriteLine("Bitte geben Sie einen Geldbetrag in Cent ein");
int centBetrag = Convert.ToInt32(Console.ReadLine()); 

int euro = centBetrag / 100; 
int cent = centBetrag % 100; 

Console.WriteLine(centBetrag+" Cent ensprechen "+ euro + " Euro und "+ cent+ "Cent");