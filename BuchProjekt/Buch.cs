
namespace BuchProjekt
{
    public class Buch
    {
        public string Titel { get; set; }
        public string Autor { get; set; }
        public int Seitenzahl { get; set; }
        public int Erscheinungsjahr { get; set; }
        public float Preis { get; set; }

        public Buch(string titel, string autor, int seitenzahl, int erscheinungsjahr, float preis)
        {
            Titel = titel;
            Autor = autor;
            Seitenzahl = seitenzahl;
            Erscheinungsjahr = erscheinungsjahr;
            Preis = preis;
        }

        public void Details()
        {
            Console.WriteLine($"Titel: {Titel}, Autor: {Autor}, Seiten: {Seitenzahl}, Erscheinungsjahr: {Erscheinungsjahr}, Preis: {Preis} euro");
        }
    }
}