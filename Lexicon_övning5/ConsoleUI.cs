using Lexicon_övning5.Interface;

namespace Lexicon_övning5
{
    internal class ConsoleUI : IUI
    {

        public void DisplayMenu()
        {
            Console.WriteLine("1. Sätt kapacitet och skapa nytt garage utrymme");
            Console.WriteLine("2. Populera garaget med ett antal fordon");

            Console.WriteLine("3. Lista samtliga parkerade fordon");
            Console.WriteLine("4. Lista fordonstyper och hur många av varje som står i garaget");

            Console.WriteLine("5. Lägga till fordon i garaget");
            Console.WriteLine("6. Ta bort fordon ur garaget");

            Console.WriteLine("4. Hitta ett specifikt fordon via registreringsnumret.");
            Console.WriteLine("4. Sök efter fordon utifrån en eller flera egenskaper.");

            Console.WriteLine("5. Avsluta");
        }

        public string GetUserInput()
        {
            Console.WriteLine("Välj ett alternativ: ");
            return Console.ReadLine()!;
        }

        public void ShowMessage(string message)
        {

        }
    }
}
