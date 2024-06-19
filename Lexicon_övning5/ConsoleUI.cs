using Lexicon_övning5.Garage;
using Lexicon_övning5.Interface;
using Lexicon_övning5.Vehicle;

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

            // Collecting vehicle details
            Console.WriteLine("Enter Registration Number:");
            string regNumber = GetUserInput();
            Console.WriteLine("Enter Color:");
            string color = GetUserInput();
            Console.WriteLine("Enter Number of Wheels:");
            int wheels = int.Parse(GetUserInput());
            Console.WriteLine("Enter Weight in KG:");
            int weight = int.Parse(GetUserInput());
            Console.WriteLine("Enter Max Speed:");
            int maxSpeed = int.Parse(GetUserInput());


            IVehicle vehicle = null;

            switch (input)
            {
                case '1':
                    Console.WriteLine("Enter Number of Engines:");
                    int engines = int.Parse(GetUserInput());
                    vehicle = new Airplane(regNumber, color, wheels, weight, maxSpeed, engines);
                    break;

                case '2':
                    Console.WriteLine("Enter Length:");
                    double length = double.Parse(GetUserInput());
                    vehicle = new Boat(regNumber, color, wheels, weight, maxSpeed, length);
                    break;

                case '3':
                    Console.WriteLine("Enter Number of Seats:");
                    int seats = int.Parse(GetUserInput());
                    vehicle = new Bus(regNumber, color, wheels, weight, maxSpeed, seats);
                    break;
                case '4':
                    Console.WriteLine("Enter Fuel Type:");
                    string fuelType = GetUserInput();
                    vehicle = new Car(regNumber, color, wheels, weight, maxSpeed, fuelType);
                    break;

                case '5':
                    Console.WriteLine("Enter Cylinder Volume:");
                    int cylinderVolume = int.Parse(GetUserInput());
                    vehicle = new Motorcycle(regNumber, color, wheels, weight, maxSpeed, cylinderVolume);
                    break;

                default:
                    Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                    break;
            }
            if (vehicle != null)
            {
                if (handler.AddVehicle(vehicle))
                {
                    Console.WriteLine("Vehicle added successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to add vehicle.");
                }
            }

        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter the registration number of the vehicle to remove:");
            string regNumber = GetUserInput();
            if (handler.RemoveVehicle(regNumber))
            {
                Console.WriteLine("Vehicle removed successfully.");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        public void FindVehicle()
        {
            Console.WriteLine("Enter the registration number of the vehicle to find:");
            string regNumber = GetUserInput();
            var vehicle = handler.FindVehicle(regNumber);


            if (vehicle != null)
            {
                Console.WriteLine($"Vehicle found: {vehicle.ToString()}");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        public void ListAllVehicles()
        {
            IEnumerable<IVehicle> vehicles = handler.ListVehicles();

            if (vehicles.Any())
            {
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle.ToString()); // Print details of each vehicle
                }
            }
            else
            {
                Console.WriteLine("No vehicles found in the garage.");
            }
        }

        public void PopulateGarage()
        {
            if (handler != null && handler.GetGarageCapacity())
            {
                handler.AddVehicle(new Car("CAR123", "Red", 4, 1500, 200, "Petrol"));
                handler.AddVehicle(new Motorcycle("MOTO456", "Blue", 2, 200, 180, 600));
                handler.AddVehicle(new Bus("BUS789", "Yellow", 6, 5000, 100, 50));
                handler.AddVehicle(new Boat("BOAT012", "White", 0, 3000, 40, 25.5));
                handler.AddVehicle(new Airplane("AIR345", "Silver", 8, 18000, 900, 4));

                Console.WriteLine("Garage populated with a few vehicles.");
            }
            else
            {
                Console.WriteLine("Please create a garage first with a minimum of '5' total capacity.");
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

            Console.WriteLine("8. Skapa nytt Garage.");

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
