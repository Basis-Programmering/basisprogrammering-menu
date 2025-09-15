namespace basisprogrammering_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SPILMENU ===");
            Console.WriteLine("1) Start spil");
            Console.WriteLine("2) Indstillinger");
            Console.WriteLine("3) Highscore");
            Console.WriteLine("4) Credits");
            Console.WriteLine("5) Afslut");

            Console.Write("\nVælg (1-5): ");
            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    Console.WriteLine("Starter spil ...");
                    break;
                case "2":
                    Console.WriteLine("Åbner indstillinger ...");
                    break;
                case "3":
                    Console.WriteLine("Viser highscore ...");
                    break;
                case "4":
                    Console.WriteLine("Laver credits ...");
                    break;
                case "5":
                    Console.WriteLine("Afslutter. Farvel!");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;
            }

            Console.WriteLine("Tryk en tast for at afslutte...");
            Console.ReadKey(true);

        }
    }
}
