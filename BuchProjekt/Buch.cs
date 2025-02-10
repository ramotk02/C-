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
            Titel = " Das marokkanische Wunderkästlein";
            Autor = "Ahmed Sefrioui";
            Seitenzahl = 350;
            Erscheinungsjahr = 1954;
        }

        public void Details()
        {
            Console.WriteLine($"Titel: {Titel}, Autor: {Autor}");
        }
    }
}
