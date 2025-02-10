namespace BuchProjekt
{
    public class Buch
    {
        public string Titel { get; set; }
        public string Autor { get; set; }
        public int Seitenzahl {get; set; }
        public int Erscheinungsjahr {get; set; }

        public Buch()
        {
            Titel = "La Boîte à merveilles";
            Autor = "Ahmed Sefrioui";
            Seitenzahl = 350;
            Erscheinungsjahr = 1954;

        }

        public void ZeigeDetails()
        {
            Console.WriteLine($"Titel: {Titel}, Autor: {Autor}");
        }
    }
}
