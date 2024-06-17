namespace Lexicon_övning5
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //GarageHandler garageHandler = new GarageHandler();

            //bool running = true;

            ConsoleUI consoleUI = new ConsoleUI();


            consoleUI.NewGarage();



            while (true)
            {


                consoleUI.DisplayMenu();

                char input = consoleUI.GetUserInput()[0];


                switch (input)
                {
                    case '1':

                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case '4':
                        consoleUI.AddVehicle();
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }


            }

        }



    }
}
