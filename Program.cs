namespace basisprogrammering_menu
{
    internal class Program
    {
        enum Menustate { StartGame, Settings, HighScore, Credits, Exit }
        enum Race { Orc=1, Dwarf, Elf, Human}
        enum Class { Warrior=1, Mage, Rogue }
        enum Faction { Horde=1, Alliance=2 }
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
            Menustate menuState = (Menustate)int.Parse(valg)-1;

            switch (menuState)
            {
                case Menustate.StartGame:
                    Console.WriteLine("\n=== CHARACTER BUILDER ===");

                    Console.WriteLine("Vælg Faction:");
                    Console.WriteLine("1) Horde");
                    Console.WriteLine("2) Alliance");
                    Console.Write("Valg: ");
                    string factionValg = Console.ReadLine();

                    Faction factionChoise = (Faction)int.Parse(factionValg);
                                        
                    Console.WriteLine("\nVælg Race:");
                    Console.WriteLine("1) Orc");
                    Console.WriteLine("2) Human");
                    Console.WriteLine("3) Elf");
                    Console.WriteLine("4) Dwarf");
                    Console.Write("Valg: ");

                    string raceValg = Console.ReadLine();
                    Race raceChoise = (Race)int.Parse(raceValg);
                   

                    Console.WriteLine("\nVælg Class:");
                    Console.WriteLine("1) Warrior");
                    Console.WriteLine("2) Mage");
                    Console.WriteLine("3) Rogue");
                    Console.Write("Valg: ");
                    string classValg = Console.ReadLine();
                    //Class is a protected name, uden the mortal kombat writing :)

                    Class ClassChoise = (Class)int.Parse(classValg);
                    
                    Console.Write("\nSkriv et karakternavn: ");
                    string navn = Console.ReadLine();

                    Console.WriteLine($"\nHello \"{navn}\" you are a {factionChoise} {raceChoise} {ClassChoise}.");


                    switch (factionChoise)
                    {
                        case Faction.Horde:
                            Console.WriteLine("For the Horde!");
                            break;
                        case Faction.Alliance:
                            Console.WriteLine("For the Alliance!");
                            break;
                        default:
                            break;
                    }                  

                    if (raceChoise==Race.Orc && ClassChoise == Class.Warrior)
                    {
                        Console.WriteLine("Lok'tar Ogar, brave warrior!");
                    }

                    if (ClassChoise == Class.Mage)
                    {
                        Console.WriteLine("May your mana be full.");
                    }
                    break;
                case Menustate.Settings:
                    Console.WriteLine("Åbner indstillinger ...");
                    break;
                case Menustate.HighScore:
                    Console.WriteLine("Viser highscore ...");
                    break;
                case Menustate.Credits:
                    Console.WriteLine("Laver credits ...");
                    break;
                case Menustate.Exit:
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
