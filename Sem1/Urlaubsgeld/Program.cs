Console.WriteLine("Urlaubsgeld-Rechner");

Console.WriteLine("Wie viele Tage dauert die Reise?");
int tage = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Was kostet das Essen am Tag?");
int essen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Was kostet ein einzelner Flug?");
int flug = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Was kostet eine Übernachtung?");
int übernachtung = Convert.ToInt32(Console.ReadLine());

int total = (essen * tage) + flug + (übernachtung * tage);

Console.WriteLine("Die Gesamtkosten belaufen sich auf " + total + " Euro");
