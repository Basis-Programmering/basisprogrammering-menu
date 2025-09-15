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
                    Console.WriteLine("\n=== CHARACTER BUILDER ===");

                    Console.WriteLine("Vælg Faction:");
                    Console.WriteLine("1) Horde");
                    Console.WriteLine("2) Alliance");
                    Console.Write("Valg: ");
                    string factionValg = Console.ReadLine();
                    string faction = factionValg == "1" ? "Horde"
                                  : factionValg == "2" ? "Alliance"
                                  : "Ukendt faction";

                    Console.WriteLine("\nVælg Race:");
                    Console.WriteLine("1) Orc");
                    Console.WriteLine("2) Human");
                    Console.WriteLine("3) Elf");
                    Console.WriteLine("4) Dwarf");
                    Console.Write("Valg: ");
                    string raceValg = Console.ReadLine();
                    string race = raceValg == "1" ? "Orc"
                               : raceValg == "2" ? "Human"
                               : raceValg == "3" ? "Elf"
                               : raceValg == "4" ? "Dwarf"
                               : "Ukendt race";

                    Console.WriteLine("\nVælg Class:");
                    Console.WriteLine("1) Warrior");
                    Console.WriteLine("2) Mage");
                    Console.WriteLine("3) Rogue");
                    Console.Write("Valg: ");
                    string classValg = Console.ReadLine();
                    //Class is a protected name, uden the mortal kombat writing :)
                    string klass = classValg == "1" ? "Warrior"
                               : classValg == "2" ? "Mage"
                               : classValg == "3" ? "Rogue"
                               : "Ukendt class";

                    Console.Write("\nSkriv et karakternavn: ");
                    string navn = Console.ReadLine();

                    Console.WriteLine($"\nHello \"{navn}\" you are a {faction} {race} {klass}.");

                    // Additional messages based on choice
                    if (faction == "Horde")
                    {
                        Console.WriteLine("For the Horde!");
                    }
                    else if (faction == "Alliance")
                    {
                        Console.WriteLine("For the Alliance!");
                    }

                    if (race == "Orc" && klass == "Warrior")
                    {
                        Console.WriteLine("Lok'tar Ogar, brave warrior!");
                    }

                    if (klass == "Mage")
                    {
                        Console.WriteLine("May your mana be full.");
                    }
                    break;

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
