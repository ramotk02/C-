using BuchProjekt;

String x="";

while(x==""){
Console.Write("Gib den Titel des Buches ein: ");
string titel = Console.ReadLine();

Console.Write("Gib den Autor des Buches ein: ");
string autor = Console.ReadLine();

Console.Write("Gib die Seitenzahl ein: ");
int seitenzahl = int.Parse(Console.ReadLine());

Console.Write("Gib das Erscheinungsjahr ein: ");
int erscheinungsjahr = int.Parse(Console.ReadLine());

Console.Write("Gib den Preis ein: ");
int preis = int.Parse(Console.ReadLine());


Buch buch = new Buch(titel, autor, seitenzahl, erscheinungsjahr, preis);

buch.Details();
}
 