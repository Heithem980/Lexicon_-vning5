using Lexicon_övning5.Garage;
using Lexicon_övning5.Interface;

namespace Lexicon_övning5
{
    internal class ConsoleUI : IUI
    {

        private GarageHandler? handler;
        private string? input;


        public void NewGarage()
        {
            Console.WriteLine("Ange kapacitet för Garaget: ");

            input = GetUserInput();



            if (IsValidInteger(input, out int parsedValue))
            {
                handler = new GarageHandler(parsedValue);

                Console.WriteLine($"Garage skapat med {parsedValue} platser.");


            }
            else
            {
                Console.WriteLine($"'{input}' is not a valid integer.");
            }

        }

        public void AddVehicle()
        {

            Console.WriteLine("What type of vehicle would you like to add? \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Airplane"
                    + "\n2. Boat"
                    + "\n3. Bus"
                    + "\n4. Car"
                    + "\n5. Motorcycle");



            char input = GetUserInput()[0];


            switch (input)
            {
                case '1':

                    break;
                case '2':

                    break;
                case '3':

                    break;
                case '4':

                    break;

                case '5':

                    break;
                default:
                    Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                    break;
            }


        }


        public void DisplayMenu()
        {
            Console.WriteLine("1. Populera garaget med ett antal fordon");

            Console.WriteLine("2. Lista samtliga parkerade fordon");
            Console.WriteLine("3. Lista fordonstyper och hur många av varje som står i garaget");

            Console.WriteLine("4. Lägga till fordon i garaget");
            Console.WriteLine("5. Ta bort fordon ur garaget");

            Console.WriteLine("6. Hitta ett specifikt fordon via registreringsnumret.");
            Console.WriteLine("7. Sök efter fordon utifrån en eller flera egenskaper.");

            Console.WriteLine("0. Avsluta?\n");


            Console.WriteLine("Välj ett alternativ: ");
        }

        public string GetUserInput()
        {

            return Console.ReadLine()!;
        }



        public void ShowMessage(string message)
        {

        }


        public bool IsValidInteger(string input, out int result)
        {
            // check if the input is not null, empty, or white-space only
            if (string.IsNullOrWhiteSpace(input))
            {
                result = 0;
                return false;
            }

            // try to parse the input as an integer
            return int.TryParse(input, out result);
        }


    }
}
